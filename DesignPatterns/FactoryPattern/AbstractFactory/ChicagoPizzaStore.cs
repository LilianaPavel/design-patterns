using System;

namespace DesignPatterns.FactoryPattern.AbstractFactory
{
    class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(String type)
        {
            switch (type)
            {
                case "cheese":
                    return new CheesePizza(new ChicagoPizzaIngredientFactory());
                default:
                    return null;
            }
        }
    }
}
