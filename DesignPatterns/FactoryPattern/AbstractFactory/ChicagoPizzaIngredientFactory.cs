using System;

namespace DesignPatterns.FactoryPattern.AbstractFactory
{
    class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            Console.WriteLine("Mozzarella Cheese");
            return new MozzarellaCheese();
        }
    }
}
