using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Bridge.Models
{
    //Concret Implimentator in Bridge Pattern
    public class TablesList : Entity
    {
        private List<string> _tablesList = new List<string>();
        private int _current = 0;

        public TablesList()
        {
            // Loaded from a database 

            _tablesList.Add("Table Nr.1");
            _tablesList.Add("Table Nr.2");
            _tablesList.Add("Table Nr.5");
        }

        public override void NextRecord()
        {
            if (_current <= _tablesList.Count - 1)
            {
                _current++;
            }
        }

        public override void PriorRecord()
        {
            if (_current > 0)
            {
                _current--;
            }
        }

        public override void AddRecord(string table)
        {
            _tablesList.Add(table);
        }

        public override void DeleteRecord(string table)
        {
            _tablesList.Remove(table);
        }

        public override void ShowRecord()
        {
            Console.WriteLine(_tablesList[_current]);
        }

        public override void ShowAllRecords()
        {
            foreach (string table in _tablesList)
            {
                Console.WriteLine(" " + table);
            }
        }
    }
}
