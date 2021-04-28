using CoffeLand.Adapter.Models;
using System;

namespace CoffeLand.Adapter
{
    public class View
    {
        public void GetView()
        {
            Console.Clear();

            Drink newDrink1 = new SpecialDrink("Americano");
            newDrink1.ShowInfo();
            Drink newDrink2 = new SpecialDrink("Cappucino");
            newDrink2.ShowInfo();
            Drink newDrink3 = new SpecialDrink("Espresso");
            newDrink3.ShowInfo();

        }
    }
}
