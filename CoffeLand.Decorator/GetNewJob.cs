using CoffeLand.Decorator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Decorator
{
    public class GetNewJob : Job
    {
        protected List<string> jobList = new List<string>();
        public GetNewJob(Entity entity) : base(entity)
        {
        }

        public void AddJob(string jobName)
        {
            jobList.Add(jobName);
        }

        public void DeleteJob(string name)
        {
            if (jobList.Contains(name))
                jobList.Remove(name);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Job list : ");
            foreach(var obj in jobList)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
