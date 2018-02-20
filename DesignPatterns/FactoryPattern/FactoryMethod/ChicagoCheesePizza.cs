using System;

namespace DesignPatterns.FactoryPattern.FactoryMethod
{
    class ChicagoCheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Chicago Cheese Pizza - prepare");
        }

        public override void Bake()
        {
            Console.WriteLine("Chicago Cheese Pizza - bake");
        }

        public override void Cut()
        {
            Console.WriteLine("Chicago Cheese Pizza - cut");
        }

        public override void Box()
        {
            Console.WriteLine("Chicago Cheese Pizza - box");
        }
    }
}
