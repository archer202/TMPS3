using CoffeLand.Decorator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Decorator
{
    public class View
    {
        public void GetView()
        {
            var worker = new Worker("Artur");
            var newJob = new GetNewJob(worker);
            newJob.AddJob("Musarshic");
            newJob.AddJob("Taxist");
            newJob.DisplayInfo();
        }
    }
}
