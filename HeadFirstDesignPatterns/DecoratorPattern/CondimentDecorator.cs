using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;
        public abstract override string getDescription();
    }
}
