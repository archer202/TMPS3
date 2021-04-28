using CoffeLand.Interfaces;
using CoffeLand.Models;

namespace CoffeLand.Processes
{
    public class MakeBrownieWithChoclate : IMakeBrownies
    {
        public IBrownie GetBrownie()
        {
            return new BrownieWithChoclate();
        }
    }
}
