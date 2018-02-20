using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern.FactoryMethod
{
    abstract class PizzaStore
    {
        public Pizza Order(string type)
        {
            Pizza pizza = CreatePizza(type); 
            
            if (pizza != null)
            {
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();
            }
            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
