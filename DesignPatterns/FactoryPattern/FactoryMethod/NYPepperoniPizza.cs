using System;

namespace DesignPatterns.FactoryPattern.FactoryMethod
{
    class NYPepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("New York Pepperoni Pizza - prepare");
        }

        public override void Bake()
        {
            Console.WriteLine("New York Pepperoni Pizza - bake");
        }

        public override void Cut()
        {
            Console.WriteLine("New York Pepperoni Pizza - cut");
        }

        public override void Box()
        {
            Console.WriteLine("New York Pepperoni Pizza - box");
        }
    }
}
