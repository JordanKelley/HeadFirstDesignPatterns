using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.DecoratorPattern
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double cost()
        {
            return 1.99;
        }
    }
}
