using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Facade.Models
{
    public class Worker
    {
        public Worker(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
    }
}
