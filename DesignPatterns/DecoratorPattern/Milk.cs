using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
            this.Description = this.beverage.Description + ", Milk";
        }

        public override double Cost()
        {
            return this.beverage.Cost() + 0.1 ;
        }
    }
}
