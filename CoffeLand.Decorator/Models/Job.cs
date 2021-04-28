using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Decorator.Models
{
    public abstract class Job : Entity
    {
        protected Entity entity;

        public Job(Entity entity)
        {
            this.entity = entity;
        }

        public override void DisplayInfo()
        {
            this.entity.DisplayInfo();
        }
    }
}
