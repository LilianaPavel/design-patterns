using System;

namespace DesignPatterns.StrategyPattern
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a model duck.");
        }
    }
}
