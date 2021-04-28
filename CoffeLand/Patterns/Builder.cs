using CoffeLand.Interfaces;
using CoffeLand.Models;

namespace CoffeLand.Patterns
{
    public class Builder
    {
        public Drink MakeOneCoffe(IMakeCoffe newCoffe)
        {
            newCoffe.ChoiceBeans();
            newCoffe.GrindBeans();
            newCoffe.AddWater();
            newCoffe.AddMilk();
            newCoffe.AddSugar();
            newCoffe.AddCinnamon();
            return newCoffe.GetDrink();
        }
    }
}
