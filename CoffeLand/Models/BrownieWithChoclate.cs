using CoffeLand.Interfaces;
using CoffeLand.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Models
{
    public class BrownieWithChoclate : IBrownie
    {
        public string Name { get; } = "Browni with Chocolate";
        public Filling Filling { get; } = Filling.Chocolate;
    }
}
