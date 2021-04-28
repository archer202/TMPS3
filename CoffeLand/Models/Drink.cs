using System;
using CoffeLand.Interfaces;
using CoffeLand.Models.Enums;

namespace CoffeLand.Models
{
    public class Drink : ICoffe
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Intensity CoffeIntensity { get; set; }
        public Quantity CoffeQuantity { get; set; }
        public Quantity MilkQuantity { get; set; }
        public Quantity WaterQuantity { get; set; }
        public Quantity SugarQuantity { get; set; }
        public Quantity CinnamonQuantity { get; set; }

        public ICoffe Clone()
        {
            return (ICoffe)MemberwiseClone();
        }
    }
}
