using CoffeLand.Interfaces;
using CoffeLand.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Processes
{
    public class MakeBrownieWithRaspberry : IMakeBrownies
    {
        public IBrownie GetBrownie()
        {
            return new BrownieWithRaspberry();
        }
    }
}
