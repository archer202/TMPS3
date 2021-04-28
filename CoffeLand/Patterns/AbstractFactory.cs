using CoffeLand.Interfaces;
using CoffeLand.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Patterns
{
    public class AbstractFactory
    {
        private Menu choosenMenu = new Menu();
        public AbstractFactory(IGetMenu menuType)
        {
            choosenMenu.Browni = menuType.GetTypeOfBrownie();
            choosenMenu.Drink = menuType.GetTypeOfDrink();
        }

        public void GetMenu()
        {
            Console.WriteLine($"Bautura : {choosenMenu.Drink.Name}");
            Console.WriteLine($"Desertul : {choosenMenu.Browni.Name}");
        }
    }
}
