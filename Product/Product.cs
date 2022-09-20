using System;
using System.Collections.Generic;
using System.Text;

namespace ProductClassLibrary
{
    public class Product
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
            Manufacturer = "No Manufactorer Set";
            Model = "No Model Set";
            Price = 0.00M;
        }

        public Product(string a, string b, decimal c)
        {
            Manufacturer = a;
            Model = b;
            Price = c;
        }

    }
}
