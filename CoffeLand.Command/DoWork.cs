using System;

namespace CoffeLand.Command
{
    public class DoWork : Command
    {
        public DoWork(Receiver receiver) : base(receiver)
        {

        }

        public override void Execute()
        {
            receiver.Work();
        }
    }
}
