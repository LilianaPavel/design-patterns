using System;

namespace DesignPatterns.StrategyPattern
{
    class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I cannot fly.");
        }
    }
}
