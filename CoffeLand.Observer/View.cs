using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Observer
{
    public class View
    {
        public void GetView()
        {
            Shop coffeShop = new Shop();

            coffeShop.Attach(new Action(coffeShop, "Bucatarie"));
            coffeShop.Attach(new Action(coffeShop, "WC"));
            coffeShop.Attach(new Action(coffeShop, "Sala de oaspeti"));

            coffeShop.SubjectState = "inchis";
            coffeShop.Notify();

            // Wait for user

            Console.ReadKey();
        }
    }
}
