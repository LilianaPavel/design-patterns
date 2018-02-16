using System;

namespace DesignPatterns.StrategyPattern
{
    class RedheadDuck: Duck
    {
        public override void Display()
        {
            Console.WriteLine("I am a redhead duck.");
        }
    }
}
