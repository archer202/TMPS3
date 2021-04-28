using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Composite
{
    public class Manager : Worker, IManager
    {
        protected List<Worker> workersUnderMyCommand = new List<Worker>();
        public Manager(string name , string age)
        {
            Name = name;
            Age = age;
        }

        public void AddWorker(Worker worker)
        {
            workersUnderMyCommand.Add(worker);
        }

        public override void DoWork(string info)
        {
            Console.WriteLine("I " +Name + " serve " + info + " for " + Age + " years");
            foreach(var obj in workersUnderMyCommand)
            {
                obj.DoWork(Name);
            }
        }

        public void RemoveWorker(Worker worker)
        {
            workersUnderMyCommand.Remove(worker);
        }

        public override string ReportInfo()
        {
            var info = Name + " - manager";
            foreach(var obj in workersUnderMyCommand)
            {
                info += " " + obj.ReportInfo();
            }

            return info;
        }
    }
}
