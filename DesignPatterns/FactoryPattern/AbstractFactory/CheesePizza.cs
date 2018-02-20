using System;

namespace DesignPatterns.FactoryPattern.AbstractFactory
{
    class CheesePizza : Pizza
    {
        PizzaIngredientFactory factory;
        public CheesePizza(PizzaIngredientFactory factory)
        {
            this.factory = factory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Cheese Pizza - prepare");
            factory.createCheese();

        }

        public override void Bake()
        {
            Console.WriteLine("Cheese Pizza - bake");
        }

        public override void Cut()
        {
            Console.WriteLine("Cheese Pizza - cut");
        }

        public override void Box()
        {
            Console.WriteLine("Cheese Pizza - box");
        }
    }
}
