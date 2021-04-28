using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Composite
{
    public class View
    {
        public void GetView()
        {
            var manager = new Manager("Vlada","100");
            var barista1 = new Barista("Artur", "69");
            var barista2 = new Barista("Emil","77");
            manager.AddWorker(barista1);
            manager.AddWorker(barista2);
            manager.DoWork("Sefu");
            var data = manager.ReportInfo();
            Console.WriteLine(data);
            Console.WriteLine();


            var superBoss = new Manager("Nicolae", "22");
            superBoss.AddWorker(manager);
            superBoss.DoWork("pe mine =D ");
            data = superBoss.ReportInfo();
            Console.WriteLine(data);

        }
    }
}
