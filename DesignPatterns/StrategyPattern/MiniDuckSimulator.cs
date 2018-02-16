using System;

namespace DesignPatterns.StrategyPattern
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformeFly();
            mallard.PerformeQuack();

            Duck model = new ModelDuck();
            model.Display();
            model.PerformeFly();

            model.FlyBehavior = new FlyRocketPowered();
            model.PerformeFly();

            Console.ReadKey();
        }
    }
}
