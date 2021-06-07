using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Observer
{
    public class Subject
    {
        private List<IAction> _observers = new List<IAction>();

        public void Attach(IAction observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IAction observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IAction o in _observers)
            {
                o.Update();
            }
        }
    }
}
