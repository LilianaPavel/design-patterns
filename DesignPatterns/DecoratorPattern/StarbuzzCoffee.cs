using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    class StarbuzzCoffee
    {
        static void Main(string[] args)
        {
            Beverage coffee = new Mocha(new Milk(new Espresso()));
            Console.WriteLine("{0} costs {1}", coffee.Description, coffee.Cost());

            Console.ReadKey();
        }
    }
}
