using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CompoundPatterns
{
    public abstract class AbstractDuckFactory
    {
        public abstract Quackable createMallardDuck();
        public abstract Quackable createRedheadDuck();
        public abstract Quackable createDuckCall();
        public abstract Quackable createRubberDuck();
    }
}
