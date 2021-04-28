using System;
using CoffeLand.Models;
using CoffeLand.Helpers;
using CoffeLand.Interfaces;
using System.Collections.Generic;

namespace CoffeLand.Services
{
    public class CoffeService
    {
        public void AddCoffe()
        {
            //Conform principiului SRP fiecare clasa trebuie rezolve o anumita problema si sa aiba
            //Doar responsabilitatile sale
            //In cazul respectiv clasa Coffe Servici se ocupa cu adaugarea
            //felurilor de cafea in baza noastra de date.

            var database = Database.GetInstance();
            var newCoffe = new Drink();
            newCoffe.Id = Guid.NewGuid();
            Console.WriteLine("Introduceti denumirea cafelei :");
            Console.Write("--> ");
            newCoffe.Name = Console.ReadLine();
            Console.WriteLine("Introduceti intensitatea (1,2,3,4,5) :");
            var intensity = Console.ReadLine();
            switch (intensity)
            {
                case "1": newCoffe.CoffeIntensity = Models.Enums.Intensity.One; break;
                case "2": newCoffe.CoffeIntensity = Models.Enums.Intensity.Two; break;
                case "3": newCoffe.CoffeIntensity = Models.Enums.Intensity.Three; break;
                case "4": newCoffe.CoffeIntensity = Models.Enums.Intensity.Four; break;
                case "5": newCoffe.CoffeIntensity = Models.Enums.Intensity.Five; break;
                default:newCoffe.CoffeIntensity = Models.Enums.Intensity.One; break;
            };
            newCoffe.CoffeQuantity = Models.Enums.Quantity.Small;
            database.DrinkContext.Add(newCoffe);

            //dar salvarea datelor introduse se realizeaza de catre baza de date 
            database.SaveData();
        }

        public void GetCoffe()
        {
            var database = Database.GetInstance();
            Console.WriteLine("La moment aveti {0} tipuri de cafea in baza de date :",database.DrinkContext.Count);
            foreach(var obj in database.DrinkContext)
            {
                Console.WriteLine("Nume - " + obj.Name + " Intensitate - " + obj.CoffeIntensity + " Cantitate - " + obj.CoffeQuantity);
            }
        }

        //Implimentarea Sablonului de proiectare prototype care ne permite să clonăm obiectele
        //indiferent de proprietatile acestuia
        public List<Drink> MakeMoreCoffe(Drink newCoffe , int count)
        {
            var coffeList = new List<Drink>();
       
            for(var index=0 ; index<count ; index++)
            {
                var moreCoffe = newCoffe.Clone() as Drink;
                coffeList.Add(moreCoffe);
            }
            return coffeList;
        }

    }
}
