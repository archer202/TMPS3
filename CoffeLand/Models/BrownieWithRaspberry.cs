using CoffeLand.Interfaces;
using CoffeLand.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Models
{
    public class BrownieWithRaspberry : IBrownie
    {
        public string Name { get; } = "Brownie with raspberry";
        public Filling Filling { get; } = Filling.Raspberry;
    }
}
