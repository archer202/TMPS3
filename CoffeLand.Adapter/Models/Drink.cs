using CoffeLand.Adapter.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Adapter.Models
{
    //Target class in Adapter Pattern
    public class Drink
    {
        protected string _drinkName;
        protected Filling _filling;
        protected Intensity _intensity;
        protected Quantity _quantity;

        public Drink(string drinkName)
        {
            _drinkName = drinkName;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Bautura aleasa : " + _drinkName);
        }
    }
}
