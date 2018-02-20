using System;

namespace DesignPatterns.FactoryPattern.SimpleFactory
{
    class PepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Pepperoni Pizza - prepare");
        }

        public override void Bake()
        {
            Console.WriteLine("Pepperoni Pizza - bake");
        }

        public override void Cut()
        {
            Console.WriteLine("Pepperoni Pizza - cut");
        }

        public override void Box()
        {
            Console.WriteLine("Pepperoni Pizza - box");
        }
    }
}
