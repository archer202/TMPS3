using System;

namespace CoffeLand.Command
{
    public class Receiver
    {
        protected bool status = false;
        public void Work()
        {
            status = !status;
            if (status)
                Console.WriteLine("We are working !");
            else
                Console.WriteLine("We are closed !");
                
        }
    }
}
