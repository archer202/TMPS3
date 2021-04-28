using CoffeLand.Adapter.Models.Enums;

namespace CoffeLand.Adapter
{
    //Adaptee class in Adapter Pattern
    public class DrinksList
    {
        public Filling GetFilling(string drinkName)
        {
            switch (drinkName)
            {
                case nameof(DrinkType.Americano): return Filling.None;
                case nameof(DrinkType.Cappucino): return Filling.Chocolate;
                case nameof(DrinkType.Espresso): return Filling.None;
                default: return Filling.None;
            }
        }

        public Intensity GetIntensity(string drinkName)
        {
            switch (drinkName)
            {
                case nameof(DrinkType.Americano): return Intensity.Two;
                case nameof(DrinkType.Cappucino): return Intensity.Three;
                case nameof(DrinkType.Espresso): return Intensity.Four;
                default:return Intensity.One;
            }
        }

        public Quantity GetQuantity(string drinkName)
        {
            switch (drinkName)
            {
                case nameof(DrinkType.Americano): return Quantity.Big;
                case nameof(DrinkType.Cappucino): return Quantity.Medium;
                case nameof(DrinkType.Espresso): return Quantity.Small;
                default: return Quantity.None;
            }
        }
    }
}
