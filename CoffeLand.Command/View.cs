using System;
using System.Threading.Tasks;

namespace CoffeLand.Command
{
    public class View
    {
        public async void GetView()
        {
            Receiver receiver = new Receiver();
            Command command = new DoWork(receiver);
            Invoker invoker = new Invoker();

            // Set and execute command

            invoker.SetCommand(command);
            invoker.ExecuteCommand();
            await Task.Delay(2000);
            invoker.ExecuteCommand();

            // Wait for user

            Console.ReadKey();
        }
    }
}
