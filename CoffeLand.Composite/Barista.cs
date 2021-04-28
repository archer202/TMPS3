using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Composite
{
    public class Barista : Worker
    {
        public Barista(string name, string age)
        {
            Name = name;
            Age = age;
        }
        public override void DoWork(string info)
        {
            Console.WriteLine("I " + Name + " will serve " + info + " for " + Age + " years ");
        }

        public override string ReportInfo()
        {
            var info = Name + " - barista";
            return info;
        }
    }
}
