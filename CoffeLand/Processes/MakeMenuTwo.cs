using CoffeLand.Interfaces;
using CoffeLand.Models;
using CoffeLand.Patterns;

namespace CoffeLand.Processes
{
    public class MakeMenuTwo : IGetMenu
    {
        public IBrownie GetTypeOfBrownie()
        {
            return new BrownieWithRaspberry();
        }

        public Drink GetTypeOfDrink()
        {
            var newDrink = new MakeDrinkCappucino();
            var builder = new Builder();
            return builder.MakeOneCoffe(newDrink);
        }
    }
}
