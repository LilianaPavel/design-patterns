using System;

namespace DesignPatterns.FactoryPattern.AbstractFactory
{
    class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            Console.WriteLine("Regiano Cheese");
            return new RegianoCheese();
        }
    }
}
