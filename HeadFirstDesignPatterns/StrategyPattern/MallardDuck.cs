using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
