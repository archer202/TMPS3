using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Memento
{
    public class View
    {
        public void GetView()
        {
            Entity s = new Entity();
            s.Name = "Artur Batog";
            s.Phone = "6666";
            s.Budget = 25000.0;

            // Store internal state

            Restore m = new Restore();
            m.Memento = s.SaveMemento();

            // Continue changing originator

            s.Name = "Sirbu Nicolae";
            s.Phone = "+7777777777";
            s.Budget = 1000000.0;

            // Restore saved state

            s.RestoreMemento(m.Memento);

            // Wait for user

            Console.ReadKey();
        }
    }
}
