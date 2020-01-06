using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.AdapterPattern
{
    public class WildTurkey : Turkey
    {
        public void fly()
        {
            Console.WriteLine("I'm flying a short distance");
        }

        public void gobble()
        {
            Console.WriteLine("Gobble gobble");
        }
    }
}
