using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            this.Description = "Espresso";
        }

        public override double Cost()
        {
            return 1.00;
        }
    }
}
