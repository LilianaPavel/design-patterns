using System;

namespace DesignPatterns.StrategyPattern
{
    class MuteQuack : QuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("<silence>");
        }
    }
}
