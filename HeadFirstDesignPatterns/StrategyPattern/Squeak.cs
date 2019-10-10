using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.StrategyPattern
{
    public class Squeak : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squak");
        }
    }
}
