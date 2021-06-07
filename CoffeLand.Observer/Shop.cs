using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Observer
{
    public class Shop : Subject
    {
        private string _subjectState;
        public string SubjectState
        {
            get { return _subjectState; }
            set { _subjectState = value; }
        }
    }
}
