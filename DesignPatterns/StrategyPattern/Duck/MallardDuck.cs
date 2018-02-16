using System;

namespace DesignPatterns.StrategyPattern
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.flyBehavior = new FlyWithWings();
            this.quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a mallard duck.");
        }
    }
}
