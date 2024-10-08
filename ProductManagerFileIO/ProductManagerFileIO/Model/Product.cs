﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagerFileIO.Model
{
    internal class Product
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        // empty constructor
        public Product()
        {
            this.Code = "";
            this.Description = "";
            this.Price = 0.0m;
        }

        // full loaded constructor
        public Product(string code, string description, decimal price)
        {
            this.Code = code;
            this.Description = description;
            this.Price = price;

        }

        public override string ToString()
        {
            return $"Product - code:{Code}, desc:{Description}, price:{Price} ";
        }

    }
}
