using System;

namespace DesignPatterns.StrategyPattern
{
    class FlyRocketPowered : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket.");
        }
    }
}
