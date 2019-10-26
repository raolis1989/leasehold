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
        private readonly ICombosHelper _combosHelper;

        public ConvertHelper(
            DataContext context,
            ICombosHelper combosHelper)
        {
            _context = context;
            _combosHelper = combosHelper;
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

        public PropertyViewModel ToPropertyViewModel(Property property)
        {
            return new PropertyViewModel
            {
                Address = property.Address,
                Contracts = property.Contracts,
                HasParkingLot = property.HasParkingLot,
                Id = property.Id,
                IsAvailable = property.IsAvailable,
                Neighborhood = property.Neighborhood,
                Owner = property.Owner,
                Price = property.Price,
                PropertyImages = property.PropertyImages,
                PropertyType = property.PropertyType,
                Remarks = property.Remarks,
                Rooms = property.Rooms,
                SquareMeters = property.SquareMeters,
                Stratum = property.Stratum,
                OwnerId = property.Owner.Id,
                PropertyTypeId = property.PropertyType.Id,
                PropertyTypes = _combosHelper.GeTComboPropertyTypes()

            };
        }
    }
}
