using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Decorator.Models
{
    public class Worker : Entity
    {
        public Worker(string name)
        {
            Name = name;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Name - "+ Name);
        }
    }
}
