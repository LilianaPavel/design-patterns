using System;

namespace DesignPatterns.FactoryPattern.FactoryMethod
{
    class NYCheesePizza : Pizza
    {

        public override void Prepare()
        {
            Console.WriteLine("New York Cheese Pizza - prepare");
        }

        public override void Bake()
        {
            Console.WriteLine("New York Cheese Pizza - bake");
        }

        public override void Cut()
        {
            Console.WriteLine("New York Cheese Pizza - cut");
        }

        public override void Box()
        {
            Console.WriteLine("New York Cheese Pizza - box");
        }
    }
}
