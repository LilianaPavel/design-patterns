using System;

namespace DesignPatterns.FactoryPattern.AbstractFactory
{
    class PizzaWithIngredientsTestDrive
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
