﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaseHold.Web.Data;
using LeaseHold.Web.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using LeaseHold.Web.Models;
using LeaseHold.Web.Helpers;

namespace LeaseHold.Web.Controllers
{
    [Authorize(Roles="Manager")]
    public class OwnersController : Controller
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        private readonly ICombosHelper _combosHelper;
        private readonly IConvertHelper _convertHelper;

        public OwnersController(DataContext context,
            IUserHelper userHelper,
            ICombosHelper combosHelper,
            IConvertHelper convertHelper)
        {
            _context = context;
            _userHelper = userHelper;
            _combosHelper = combosHelper;
            _convertHelper = convertHelper;
        }

        // GET: Owners
        public IActionResult Index()
        {
            return View( _context.Owners
                .Include(o =>o.User)
                .Include(o=> o.Properties)
                .Include(o=>o.Contracts));
        }

        // GET: Owners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }



            var owner = await _context.Owners
                .Include(o => o.User)
                .Include(o => o.Properties)
                .ThenInclude(p => p.PropertyImages)
                .Include(o=>o.Contracts)
                .ThenInclude(l=>l.Lessee)
                .ThenInclude(u=>u.User)
                .FirstOrDefaultAsync(o => o.Id == id);
            
            
            if (owner == null)
            {
                return NotFound();
            }

            return View(owner);
        }

        // GET: Owners/Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await CreateUserAsync(model);

                if (user != null)
                {
                    var owner = new Owner
                    {
                        Contracts = new List<Contract>(),
                        Properties = new List<Property>(),
                        User = user

                    };

                    _context.Owners.Add(owner);
                    _context.SaveChangesAsync();

                    return RedirectToAction("Index");
                }
                ModelState.AddModelError(string.Empty, "User with this email already exists.");
            }
            return View(model);
        }

        private async Task<User> CreateUserAsync(AddUserViewModel model)
        {
            var user = new User
            {
                Address = model.Address,
                Document = model.Document,
                Email = model.Username,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                UserName = model.Username
            };

            var result = await _userHelper.AddUserAsync(user, model.Password);

            if (result.Succeeded)
            {
                user = await _userHelper.GetUserByEmailAsyncc(model.Username);

                await _userHelper.AddUserToRoleAsync(user, "Owner");

                return user; 
            }

            return null; 




        }

        // GET: Owners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var owner = await _context.Owners.FindAsync(id);
            if (owner == null)
            {
                return NotFound();
            }
            return View(owner);
        }

        // POST: Owners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Owner owner)
        {
            if (id != owner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(owner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OwnerExists(owner.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(owner);
        }

        // GET: Owners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var owner = await _context.Owners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (owner == null)
            {
                return NotFound();
            }

            return View(owner);
        }

        // POST: Owners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var owner = await _context.Owners.FindAsync(id);
            _context.Owners.Remove(owner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OwnerExists(int id)
        {
            return _context.Owners.Any(e => e.Id == id);
        }

        public async Task<IActionResult> AddProperty(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }

            var owner = await _context.Owners.FindAsync(id);


            if (owner == null)
            {
                return NotFound();
            }

            var model = new PropertyViewModel
            {
                OwnerId = owner.Id,
                PropertyTypes = _combosHelper.GeTComboPropertyTypes()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddProperty(PropertyViewModel model)
        {
            if (ModelState.IsValid)
            {
                var property = await _convertHelper.ToProperty(model, true);
                _context.Properties.Add(property);
                await _context.SaveChangesAsync();
                return RedirectToAction($"Details/{model.OwnerId}");
            }
            return View(model);
        }
    }
}
