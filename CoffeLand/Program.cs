using System;
using CoffeLand.Models;
using CoffeLand.Services;
using CoffeLand.Processes;
using CoffeLand.Patterns;

namespace CoffeLand
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool status = true;
            //var builderPattern = new Builder();
            //var factoryMethodePattern = new FactoryMethode();
            //var coffeService = new CoffeService();
            //while (status == true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Alegeti o optiune :");
            //    Console.WriteLine("1. Obtineti o cafea cu ajutorul Builder Pattern");
            //    Console.WriteLine("2. Incercati un Brownie preparat cu Factory Methode");
            //    Console.WriteLine("3. Alegeti unul din meniurile noastre Abstract Factory");
            //    Console.WriteLine("4. Iesire");
            //    var option = Console.ReadLine();
            //    if (option == "1")
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Alegeti o optiune :");
            //        Console.WriteLine("1.Americano");
            //        Console.WriteLine("2.Capuccino");
            //        var obj = Console.ReadLine();
            //        var newDrink = new Drink();
            //        if(obj == "1")
            //        {
            //            var drinkType = new MakeDrinkAmericano();
            //            newDrink = builderPattern.MakeOneCoffe(drinkType);
            //            Console.WriteLine($"Poftim {newDrink.Name} dumneavoastra");
            //        }
            //        else if(obj == "2")
            //        {
            //            var drinkType = new MakeDrinkCappucino();
            //            newDrink = builderPattern.MakeOneCoffe(drinkType);
            //            Console.WriteLine($"Poftim {newDrink.Name} dumneavoastra");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Ati introdus o optiune gresita");
            //        }
            //    }
            //    else if(option == "2")
            //    {
            //        Console.Clear();
            //        var newBrownie = factoryMethodePattern.GetABrownie();
            //        Console.WriteLine($"Poftim {newBrownie.Name}");
            //    }
            //    else if(option == "3")
            //    {
            //        Console.Clear();
            //        Console.Clear();
            //        Console.WriteLine("Alegeti o optiune :");
            //        Console.WriteLine("1.Meniul One");
            //        Console.WriteLine("2.Meniul Two");
            //        var obj = Console.ReadLine();
            //        if (obj == "1")
            //        {
            //            var menuType = new MakeMenuOne();
            //            var getMenu = new AbstractFactory(menuType);
            //            getMenu.GetMenu();
            //        }
            //        else if (obj == "2")
            //        {
            //            var menuType = new MakeMenuTwo();
            //            var getMenu = new AbstractFactory(menuType);
            //            getMenu.GetMenu();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Ati introdus o optiune gresita");
            //        }
            //    }
            //    else if(option == "4")
            //        status = false;

            //    Console.ReadKey();
            //}

            //------------------------ laborator 2 

            /* View for Adapter Pattern */
            //var newAdapter = new Adapter.View();
            //newAdapter.GetView();
            //Console.ReadKey();

            /* View for Bridge Pattern */
            //var newBridge = new Bridge.View();
            //newBridge.GetView();
            //Console.ReadKey();

            /* View for Decorator Pattern   */
            //var newDecorator = new Decorator.View();
            //newDecorator.GetView();
            //Console.ReadKey();

            /* View for Facade Pattern */
            //var newFacade = new Facade.View();
            //newFacade.GetView();
            //Console.ReadKey();

            /* View for Proxy Pattern */
            //var newProxy = new Proxy.View();
            //newProxy.GetView();
            //Console.ReadKey();

            /* View for Composite Pattern*/
            var newComposite = new Composite.View();
            newComposite.GetView();
            Console.ReadKey();

        }
    }
}
