using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern.AbstractFactory
{
    class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(String type)
        {
            switch (type)
            {
                case "cheese":
                    return new  CheesePizza(new NYPizzaIngredientFactory());
                default:
                    return null;
            }
        }
    }
}
