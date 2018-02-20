using System;

namespace DesignPatterns.FactoryPattern.FactoryMethod
{
    class PizzaTestDrive
    {
        static void Main(string[] args)
        {
            PizzaStore nystore = new NYPizzaStore();
            nystore.Order("cheese");

            PizzaStore chicagoStore = new ChicagoPizzaStore();
            chicagoStore.Order("cheese");

            Console.ReadKey();
        }
    }
}
