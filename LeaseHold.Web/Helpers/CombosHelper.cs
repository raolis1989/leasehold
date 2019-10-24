using LeaseHold.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaseHold.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _context;

        public CombosHelper(DataContext context)
        {
            _context = context;
        }


        public IEnumerable<SelectListItem> GeTComboPropertyTypes()
        {
            var list = _context.PropertyTypes.Select(pt => new SelectListItem
            {
                Text = pt.Name,
                Value = $"{pt.Id}"
            })
                .OrderBy(pt => pt.Text)
                .ToList();


            list.Insert(0, new SelectListItem
            {
                Text = "(Select a property type...)",
                Value = "0"
            });

            return list;
        }
    }
}
