using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.StrategyPattern
{
    public class Quack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
