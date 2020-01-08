using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.TemplatePattern
{
    public class Coffee : CaffeineBeverage
    {
        public override void brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        public override void addCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}
