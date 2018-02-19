﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage; 
    }
}
