using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CompoundPatterns
{
    public interface Observer
    {
        public void update(QuackObservable duck);
    }
}
