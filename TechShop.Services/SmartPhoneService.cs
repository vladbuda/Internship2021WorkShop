using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechShop.Domain.Models;

namespace TechShop.Services
{
    public class SmartPhoneService
    {
        private List<SmartPhone> _smartPhones = new List<SmartPhone>()
        {
            new SmartPhone()
            {
                Id = 1,
                Brand = "Samsung",
                Model = "Galaxy S21",
                Storage = 128,
                Price = 799
            },
            new SmartPhone()
            {
                Id = 2,
                Brand = "Apple",
                Model = "iPhone 12",
                Storage = 64,
                Price = 699
            },
            new SmartPhone()
            {
                Id = 3,
                Brand = "Google",
                Model = "Pixel 5",
                Storage = 128,
                Price = 599
            }
        };

        public List<SmartPhone> GetSmartPhones()
        {
            return _smartPhones;
        }

        public SmartPhone GetSmartPhone(int id)
        {
            var smartPhone = _smartPhones.FirstOrDefault(smartPhone => smartPhone.Id == id);

            return smartPhone;
        }
    }
}
