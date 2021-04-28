using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Adapter.Models
{
    //Adapter class in Adapter Pattern
    public class SpecialDrink : Drink
    {
        private DrinksList _drink;
        public SpecialDrink(string drinkName)
            : base(drinkName)
        {

        }

        public override void ShowInfo()
        {
            // The Adaptee

            _drink = new DrinksList();

            _filling = _drink.GetFilling(_drinkName);
            _intensity = _drink.GetIntensity(_drinkName);
            _quantity = _drink.GetQuantity(_drinkName);

            base.ShowInfo();
            Console.WriteLine(" Filling : " + _filling);
            Console.WriteLine(" Intensity : " + _intensity);
            Console.WriteLine(" Quality : " + _quantity);
        }
    }
}
