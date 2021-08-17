using System;
using System.Collections.Generic;
using System.Text;

namespace TechShop.Domain.Models
{
    public class SmartPhone
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Storage { get; set; }
        public int Price { get; set; }
    }
}
