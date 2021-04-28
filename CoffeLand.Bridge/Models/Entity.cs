using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Bridge.Models
{
    //Implimentator class in Bridge Pattern
    public abstract class Entity
    {
        public abstract void NextRecord();
        public abstract void PriorRecord();
        public abstract void AddRecord(string name);
        public abstract void DeleteRecord(string name);
        public abstract void ShowRecord();
        public abstract void ShowAllRecords();
    }
}
