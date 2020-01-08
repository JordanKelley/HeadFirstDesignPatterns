using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.TemplatePattern
{
    public class Tea : CaffeineBeverage
    {
        public override void brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void addCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}
