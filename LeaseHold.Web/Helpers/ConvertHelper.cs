using LeaseHold.Web.Data;
using LeaseHold.Web.Data.Entities;
using LeaseHold.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaseHold.Web.Helpers
{
    public class ConvertHelper : IConvertHelper
    {
        private readonly DataContext _context;

        public ConvertHelper(DataContext context)
        {
            _context = context;
        }
        public async Task<Property> ToProperty(PropertyViewModel model, bool isNew)
        {
            return new Property
            {
                Address = model.Address,
                Contracts = isNew ? new List<Contract>() : model.Contracts,
                HasParkingLot = model.HasParkingLot,
                Id = isNew ? 0 : model.Id,
                IsAvailable = model.IsAvailable,
                Neighborhood = model.Neighborhood,
                Owner = await _context.Owners.FindAsync(model.OwnerId),
                Price = model.Price,
                PropertyImages = isNew ? new List<PropertyImage>() : model.PropertyImages,
                PropertyType = await _context.PropertyTypes.FindAsync(model.PropertyTypeId),
                Remarks = model.Remarks,
                Rooms = model.Rooms,
                SquareMeters = model.SquareMeters,
                Stratum = model.Stratum

            };
        }
    }
}
