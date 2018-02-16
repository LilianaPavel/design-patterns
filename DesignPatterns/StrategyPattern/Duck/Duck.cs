using System;

namespace DesignPatterns.StrategyPattern
{
    abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        public void Swim()
        {
            Console.WriteLine("I'm swimming.");
        }

        public FlyBehavior FlyBehavior
        {
            get { return this.flyBehavior; }
            set { this.flyBehavior = value; }
        }

        public QuackBehavior QuackBehavior
        {
            get { return this.quackBehavior; }
            set { this.quackBehavior = value; }
        }

        public void PerformeQuack()
        {
            quackBehavior.QuackSound();
        }

        public void PerformeFly()
        {
            flyBehavior.Fly();
        }
        public abstract void Display();
    }
}
