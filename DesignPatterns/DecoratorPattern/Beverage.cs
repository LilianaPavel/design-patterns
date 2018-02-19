using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    abstract class Beverage
    {
        public string Description
        {
            get;
            protected set;
        }

        public abstract double Cost();
    }
}
