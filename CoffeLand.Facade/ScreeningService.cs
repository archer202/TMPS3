using CoffeLand.Facade.Database;
using CoffeLand.Facade.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Facade
{
    public class ScreeningService
    {
        private BaristaDb _barista = new BaristaDb();
        private SchoolDb _school = new SchoolDb();
        private PenalDb _penal = new PenalDb();

        public bool IsEligible(Worker worker)
        {
            Console.WriteLine("{0} applies for job\n",
              worker.Name);

            bool eligible = true;

            // Check creditworthyness of applicant

            if (!_barista.HasBaristaSkills(true))
            {
                eligible = false;
            }
            else if (!_school.HasSchoolDegree(true))
            {
                eligible = false;
            }
            else if (!_penal.HasPenalHistory(false))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
