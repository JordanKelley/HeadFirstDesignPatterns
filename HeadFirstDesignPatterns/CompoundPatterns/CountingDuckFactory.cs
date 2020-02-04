using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CompoundPatterns
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override Quackable createMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override Quackable createRedheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override Quackable createDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override Quackable createRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
