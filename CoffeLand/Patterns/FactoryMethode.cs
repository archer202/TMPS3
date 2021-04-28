using CoffeLand.Interfaces;
using CoffeLand.Processes;
using System;

namespace CoffeLand.Patterns
{
    public class FactoryMethode
    {
        public IBrownie GetABrownie()
        {
            IMakeBrownies type;
            Console.WriteLine("Doriti cu ciocolata sau zmeura?");
            var option = Console.ReadLine();
            if (option == "zmeura") {
                type = new MakeBrownieWithRaspberry();
                return type.GetBrownie();
            }
            else
            {
                type = new MakeBrownieWithChoclate();
                return type.GetBrownie();
            }          
        }
    }
}
