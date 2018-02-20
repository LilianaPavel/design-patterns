using System;

namespace DesignPatterns.FactoryPattern.SimpleFactory
{
    class SimplePizzaTestDrive
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new PizzaStore(new SimplePizzaFactory());
            pizzaStore.OrderPizza("cheese");

            pizzaStore.OrderPizza("pepperoni");

            Console.ReadKey();
        }
    }
}
