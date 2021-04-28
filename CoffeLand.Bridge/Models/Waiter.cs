using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Bridge.Models
{
    //Refined Abstraction class in Bridge Pattern
    public class Waiter : PersonalEntity
    {
        public Waiter(string group)
          : base(group)
        {
        }

        public override void ShowAll()
        {
            // Add separator lines

            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}
