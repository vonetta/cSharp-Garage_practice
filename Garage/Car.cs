﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }

        constructor
        public Car()
        {
            Price = 5000m;
            Sold = true;
        }

        public Car(string make):this()
        {
          
            Make = make; //Set the 'make' parameter to the property 'Make';
        }
    }
}


