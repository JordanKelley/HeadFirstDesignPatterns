using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.AdapterPattern
{
    public class MallardDuck : Duck
    {
        public void fly()
        {
            Console.WriteLine("I'm flying");
        }

        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
