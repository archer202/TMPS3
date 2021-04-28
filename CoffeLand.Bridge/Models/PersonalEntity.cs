using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Bridge.Models
{
    //Abstraction class in Bridge Pattern
    public class PersonalEntity
    {
        private Entity _dataObject;
        protected string group;

        public PersonalEntity(string group)
        {
            this.group = group;
        }

        // Property

        public Entity Tables
        {
            set { _dataObject = value; }
            get { return _dataObject; }
        }

        public virtual void Next()
        {
            _dataObject.NextRecord();
        }

        public virtual void Prior()
        {
            _dataObject.PriorRecord();
        }

        public virtual void Add(string customer)
        {
            _dataObject.AddRecord(customer);
        }

        public virtual void Delete(string customer)
        {
            _dataObject.DeleteRecord(customer);
        }

        public virtual void Show()
        {
            _dataObject.ShowRecord();
        }

        public virtual void ShowAll()
        {
            Console.WriteLine("Tables list for waiter  : " + group);
            _dataObject.ShowAllRecords();
        }
    }
}
