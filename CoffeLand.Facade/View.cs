using CoffeLand.Facade.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Facade
{
    public class View
    {
        public void GetView()
        {
            ScreeningService service = new ScreeningService();

            Worker worker = new Worker("Vlada");
            bool eligible = service.IsEligible(worker);

            Console.WriteLine("\n" + worker.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));
        }
    }
}
