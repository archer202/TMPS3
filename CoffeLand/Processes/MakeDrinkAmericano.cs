using CoffeLand.Interfaces;
using CoffeLand.Models;
using CoffeLand.Models.Enums;

namespace CoffeLand.Processes
{
    public class MakeDrinkAmericano : IMakeCoffe
    {
        private Drink americano = new Drink();
        public MakeDrinkAmericano()
        {
            this.NewAmericano();
            this.americano.Name = "Americano";
        }

        public void NewAmericano()
        {
            this.americano = new Drink();
        }

        public void ChoiceBeans()
        {
            this.americano.CoffeIntensity = Intensity.Three;
        }
        public void GrindBeans()
        {
            this.americano.CoffeQuantity = Quantity.Medium;
        }
        public void AddWater()
        {
            this.americano.WaterQuantity = Quantity.Medium;
        }
        public void AddMilk()
        {
            this.americano.MilkQuantity = Quantity.None;
        }
        public void AddSugar()
        {
            this.americano.SugarQuantity = Quantity.Medium;
        }
        public void AddCinnamon()
        {
            this.americano.CinnamonQuantity = Quantity.Small;
        }
        public Drink GetDrink()
        {
            Drink newDrink = this.americano;
            this.NewAmericano();
            return newDrink;
        }
    }
}
