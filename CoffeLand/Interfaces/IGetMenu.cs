using CoffeLand.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Interfaces
{
    public interface IGetMenu
    {
        public Drink GetTypeOfDrink();
        public IBrownie GetTypeOfBrownie();
    }
}
