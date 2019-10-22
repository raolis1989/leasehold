using LeaseHold.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaseHold.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckPropertyTypeAsync();
            await CheckOwnersAsync();
            await CheckLesseesAsync();
            await CheckPropertiesAsync();
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

        private async Task CheckLesseesAsync()
        {
            if (!_context.Lessees.Any())
            {
                AddLesse("876543", "Leonart", "Mendoza", "0412 3863550", " 0212 2416850", "La California el Marquez Casa #21");
                AddLesse("654565", "Aleida", "Bandres", "0426 1568987", " 0238 3340612", "Altagracia de Orituco Casa #12");
                AddLesse("241658", "Augusto", "Rubio", "0414 989877", " 0241 656898", "Intercomunal #55");
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckOwnersAsync()
        {
            if(!_context.Owners.Any())
            {
                AddOwner("89898789", "Raolis", "Mendoza", "222 4546569", "56 9 90833607", "Argomedo 320 Depto 1212");
                AddOwner("90932232", "Nancy", "Cortez", "222 23223432", "56 9 8345898", "Los Cerrillos Casa 2324");
                AddOwner("121547896", "Maholis", "Cortez", "222 78787996", "56 9 989564", "La Pintana Casa 2312");
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


        private void AddOwner(
            string document, 
            string firstName,
            string lastName, 
            string fixedPhone, 
            string cellPhone, 
            string address)
        {
            _context.Owners.Add(new Owner
            {
                Address= address,
                CellPhone= cellPhone,
                FixedPhone= fixedPhone,
                LastName= lastName,
                FirstName= firstName,
                Document= document
            });

        }

        private void AddLesse(
            string document,
            string firstName,
            string lastName,
            string cellPhone,
            string fixedPhone,
            string address)
        {
            _context.Lessees.Add(new Lessee
            {
                Address= address,
                CellPhone= cellPhone,
                FixedPhone= fixedPhone,
                LastName= lastName,
                FirstName= firstName,
                Document= document
            });
        }


    }
}
