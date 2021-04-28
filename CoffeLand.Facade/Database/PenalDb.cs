using System;

namespace CoffeLand.Facade.Database
{
    public class PenalDb
    {
        public bool HasPenalHistory(bool status)
        {
            Console.WriteLine("Check Penal History");
            return !status;
        }
    }
}
