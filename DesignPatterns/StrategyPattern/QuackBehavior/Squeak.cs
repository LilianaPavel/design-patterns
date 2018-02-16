using System;

namespace DesignPatterns.StrategyPattern
{
    class Squeak : QuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("Squeak.");
        }
    }
}
