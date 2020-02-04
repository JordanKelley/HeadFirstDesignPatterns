using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CompoundPatterns
{
    public interface Quackable : QuackObservable
    {
        public void quack();
    }
}
