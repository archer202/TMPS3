using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Proxy
{
    public class ProxyCoffeMachine : ICoffeMachine
    {
        private CoffeMachine coffeMachine = new CoffeMachine("artur","admin");
        public void DoCoffe()
        {

            coffeMachine.DoCoffe();
        }
    }
}
