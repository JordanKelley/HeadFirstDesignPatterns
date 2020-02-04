using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CompoundPatterns
{
    public class Quackologist : Observer
    {
        public void update(QuackObservable duck)
        {
            Console.WriteLine("Quackologist: " + duck + " just quacked.");
        }
    }
}
