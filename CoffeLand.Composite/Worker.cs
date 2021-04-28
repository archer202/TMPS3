using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Composite
{
    public abstract class Worker
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public abstract void DoWork(string info);
        public abstract string ReportInfo();
    }
}
