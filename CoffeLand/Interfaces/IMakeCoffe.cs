using CoffeLand.Models;

namespace CoffeLand.Interfaces
{
    public interface IMakeCoffe
    {
        public void ChoiceBeans();
        public void GrindBeans();
        public void AddWater();
        public void AddMilk();
        public void AddSugar();
        public void AddCinnamon();
        public Drink GetDrink();
    }
}
