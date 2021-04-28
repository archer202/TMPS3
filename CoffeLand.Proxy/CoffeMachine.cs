using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Proxy
{
    public class CoffeMachine : ICoffeMachine
    {
        private readonly string user = "artur";
        private readonly string password = "admin";
        private readonly bool authStatus = false;

        public CoffeMachine()
        {

        }
        public CoffeMachine(string user, string password)
        {
            if(user == this.user && password == this.password)
            {
                authStatus = true;
            }
        }
        public void DoCoffe()
        {
            if (authStatus == true)
                Console.WriteLine("Your coffe is in proggres...");
            else
                Console.WriteLine("You don't have rights to do this operation");
        }
    }
}
