using System;

namespace DesignPatterns.FactoryPattern.SimpleFactory
{
    class CheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Cheese Pizza - prepare");
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
