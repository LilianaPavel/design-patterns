using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            this.Description = this.beverage.Description + ", Mocha";
        }

        public override double Cost()
        {
            return this.beverage.Cost() + 0.20;
        }
    }
}
