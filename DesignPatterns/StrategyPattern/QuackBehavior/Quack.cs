using System;

namespace DesignPatterns.StrategyPattern
{
    class Quack: QuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("Quack.");
        }
    }
}
