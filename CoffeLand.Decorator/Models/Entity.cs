using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Decorator.Models
{
    public abstract class Entity
    {
        public string Name { get; set; }

        public abstract void DisplayInfo();
    }
}
