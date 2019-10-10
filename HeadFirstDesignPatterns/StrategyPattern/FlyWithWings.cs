using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.StrategyPattern
{
    public class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
