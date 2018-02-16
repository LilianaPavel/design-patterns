using System;

namespace DesignPatterns.StrategyPattern
{
    class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can fly.");
        }
    }
}
