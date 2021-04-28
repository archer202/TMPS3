using CoffeLand.Interfaces;
using CoffeLand.Models;
using CoffeLand.Models.Enums;

namespace CoffeLand.Processes
{
    public class MakeDrinkCappucino : IMakeCoffe
    {
        private Drink cappucino = new Drink();
        public MakeDrinkCappucino()
        {
            this.NewCappucino();
            this.cappucino.Name = "Cappucino";
        }

        public void NewCappucino()
        {
            this.cappucino = new Drink();
        }

        public void ChoiceBeans()
        {
            this.cappucino.CoffeIntensity = Intensity.Three;
        }
        public void GrindBeans()
        {
            this.cappucino.CoffeQuantity = Quantity.Medium;
        }
        public void AddWater()
        {
            this.cappucino.WaterQuantity = Quantity.Small;
        }
        public void AddMilk()
        {
            this.cappucino.MilkQuantity = Quantity.Medium;
        }
        public void AddSugar()
        {
            this.cappucino.SugarQuantity = Quantity.Medium;
        }
        public void AddCinnamon()
        {
            this.cappucino.CinnamonQuantity = Quantity.None;
        }
        public Drink GetDrink()
        {
            Drink newDrink = this.cappucino;
            this.NewCappucino();
            return newDrink;
        }
    }
}
