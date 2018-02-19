using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.Description = "Dark Roast";
        }
        public override double Cost()
        {
            return 0.99;
        }
    }
}
