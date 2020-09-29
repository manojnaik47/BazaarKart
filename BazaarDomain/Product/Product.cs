using System;
using System.Collections.Generic;
using System.Text;
using BKart.Domain;

namespace BKart.Domain.Product 
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double price { get; set; }

    }
}
