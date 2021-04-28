using System;

namespace CoffeLand.Proxy
{
    public class View
    {
        public void GetView()
        {
            Console.WriteLine("We try to use the coffe machine without to know the credentials :");
            CoffeMachine coffeMachine = new CoffeMachine();
            coffeMachine.DoCoffe();
            Console.WriteLine();

            Console.WriteLine("We try to use coffe machine with a proxy program :");
            ProxyCoffeMachine proxyCoffeMachine = new ProxyCoffeMachine();
            proxyCoffeMachine.DoCoffe();
        }
    }
}
