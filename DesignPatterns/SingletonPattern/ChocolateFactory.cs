using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    class ChocolateFactory
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler = ChocolateBoiler.Instance;
            boiler.Fill();
            boiler.Boil();
            boiler.Drain();

            Console.ReadKey();
        }
    }
}
