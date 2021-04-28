using CoffeLand.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Models
{
    public class Menu
    {
        public IBrownie Browni { get; set; }
        public Drink Drink { get; set; }
    }
}
