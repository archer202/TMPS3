using CoffeLand.Interfaces;
using CoffeLand.Models;
using CoffeLand.Patterns;

namespace CoffeLand.Processes
{
    public class MakeMenuOne : IGetMenu
    {
        public IBrownie GetTypeOfBrownie()
        {
            return new BrownieWithChoclate();
        }

        public Drink GetTypeOfDrink()
        {
            var newDrink = new MakeDrinkAmericano();
            var builder = new Builder();
            return builder.MakeOneCoffe(newDrink);
        }
    }
}
