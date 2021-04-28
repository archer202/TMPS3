using CoffeLand.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Interfaces
{
    public interface IBrownie
    {
        public string Name { get; }
        public Filling Filling { get; }
    }
}
