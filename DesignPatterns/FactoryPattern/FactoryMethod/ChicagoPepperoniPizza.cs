using System;

namespace DesignPatterns.FactoryPattern.FactoryMethod
{
    class ChicagoPepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Chicago Pepperoni Pizza - prepare");
        }

        public override void Bake()
        {
            Console.WriteLine("Chicago Pepperoni Pizza - bake");
        }

        public override void Cut()
        {
            Console.WriteLine("Chicago Pepperoni Pizza - cut");
        }

        public override void Box()
        {
            Console.WriteLine("Chicago Pepperoni Pizza - box");
        }
    }
}
