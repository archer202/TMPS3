using CoffeLand.Bridge.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Bridge
{
    public class View
    {
        public void GetView()
        {
            PersonalEntity waiter = new Waiter("Vasile");

            waiter.Tables = new TablesList();

            waiter.Show();
            waiter.Next();
            waiter.Show();
            waiter.Next();
            waiter.Show();
            waiter.Add("Table nr.4");

            waiter.ShowAll();

        }
    }
}
