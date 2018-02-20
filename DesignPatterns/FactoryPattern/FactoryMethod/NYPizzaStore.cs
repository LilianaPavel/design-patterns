using System;

namespace DesignPatterns.FactoryPattern.FactoryMethod
{
    class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(String type)
        {
            switch (type)
            {
                case "cheese":
                    return new NYCheesePizza();
                case "pepperoni":
                    return new NYPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
