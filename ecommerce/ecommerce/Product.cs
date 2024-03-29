﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Active { get; set; }
        public List<Comment> Comments { get; set; }
        public int Stock { get; set; }
        public List<KeyValuePair<Client, int>> Reservations { get; set; }
        public Vendor Vendor { get; set; }

        public Product(string name, string description, double price, Vendor vendor) 
        { 
            Name = name;
            Description = description;
            Price = price;
            Stock = 0;
            Active = true;
            Vendor = vendor;
            Comments = new List<Comment> { };
            Reservations = new List<KeyValuePair<Client, int>> { };
        }
    }
}
