using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Observer
{
    public class Action : IAction
    {
        private string _name;
        private string _observerState;
        private Shop _subject;

        public Action(Shop subject, string name)
        {
            this._subject = subject;
            this._name = name;
        }

        public void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine("Statutul {0} este {1}",
              _name, _observerState);
        }

        // Gets or sets subject

        public Shop Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
    }
}
