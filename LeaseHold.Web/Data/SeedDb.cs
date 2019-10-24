using LeaseHold.Web.Data.Entities;
using LeaseHold.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaseHold.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(DataContext context,  IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckRoles();
            var manager = await CheckUserAsync("19023493", "Raolis", "Mendoza", "raolis1989@gmail.com", "56 9 90833607", "Argomedo 320", "Manager");
            var owner = await CheckUserAsync("18181208", "Edi", "Mendoza", "raolismendoza@gmail.com", "56 9 90833607", "Lira 320", "Owner"); 
            var lessee = await CheckUserAsync("261243977", "Nancy", "Cortez", "ncrm2801@gmail.com", "56 9 90833607", "Apumanque 320", "Lessee"); 
            await CheckPropertyTypeAsync();
            await CheckManagerAsync(manager);
            await CheckOwnersAsync(owner);
            await CheckLesseesAsync(lessee);
            await CheckPropertiesAsync();
            await CheckContractAsync();
        }

        private async Task CheckManagerAsync(User user)
        {
            if(!_context.Managers.Any())
            {
                _context.Managers.Add(new Manager { User = user });
                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckContractAsync()
        {
            var owner = _context.Owners.FirstOrDefault();
            var lesse = _context.Lessees.FirstOrDefault();
            var property = _context.Properties.FirstOrDefault();
            if (!_context.Contracts.Any())
            {
                _context.Contracts.Add(new Contract
                {
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddYears(1),
                    IsActive = true,
                    Lessee= lesse,
                    Owner= owner,
                    Price= 800000M,
                    Property= property, 
                    Remarks= "Lorem ipsum dolor sit amet, consectetur adipiscing elit"+
                    " Duis iaculis lobortis mi, nec luctus massa blandit id. Duis commodo, " +
                    "tortor non finibus dictum, augue magna elementum neque, at semper tellus"+
                    "neque ut quam. Etiam at risus aliquam, interdum nibh at, ullamcorper est."+
                    "Quisque eget molestie risus, nec porttitor arcu"
                }) ;

                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckPropertiesAsync()
        {
            var owner = _context.Owners.FirstOrDefault();
            var lessee = _context.Lessees.FirstOrDefault();
            var propertyType = _context.PropertyTypes.FirstOrDefault();
            
            if(!_context.Properties.Any())
            {
                AddProperty("Argomedo 321", "Poblado", owner, propertyType, 800000M, 2, 72, 4);
                AddProperty("Santa Lucia 002", "Urbanizacion", owner, propertyType, 950000M, 2, 72, 4);
                await _context.SaveChangesAsync();
            }
        }

        private void AddProperty(
            string address, 
            string neighborhood,
            Owner owner, 
            PropertyType propertyType,
            decimal price, 
            int rooms, 
            int squareMeters, 
            int stratum)
        {
            _context.Properties.Add(new Property
            {
                Address= address,
                HasParkingLot=true,
                IsAvailable=true,
                Neighborhood= neighborhood,
                Owner= owner,
                Price= price,
                PropertyType= propertyType,
                Rooms=rooms,
                SquareMeters= squareMeters,
                Stratum= stratum
            });
        }

        private async Task CheckLesseesAsync(User user)
        {
            if (!_context.Lessees.Any())
            {
                _context.Lessees.Add(new Lessee { User = user });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckOwnersAsync(User user)
        {
            if(!_context.Owners.Any())
            {
                _context.Owners.Add(new Owner { User = user });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckPropertyTypeAsync()
        {
            if(!_context.PropertyTypes.Any())
            {
                _context.PropertyTypes.Add(new Entities.PropertyType { Name = "Apartamento" });
                _context.PropertyTypes.Add(new Entities.PropertyType { Name = "Casa" });
                _context.PropertyTypes.Add(new Entities.PropertyType { Name = "Local" });
                _context.PropertyTypes.Add(new Entities.PropertyType { Name = "Terreno" });

                await _context.SaveChangesAsync();
                
            }
        }
        private async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("Manager");
            await _userHelper.CheckRoleAsync("Owner");
            await _userHelper.CheckRoleAsync("Lessee");
        }

        private async Task<User> CheckUserAsync(
            string document, 
            string firstName,
            string lastName, 
            string email, 
            string phone, 
            string address, 
            string role)
        {
            var user = await _userHelper.GetUserByEmailAsyncc(email);
            if(user==null)
            {
                user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = email,
                    PhoneNumber = phone,
                    Address = address,
                    Document = document

                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, role);
            }
            return user;
        }



    }
}
