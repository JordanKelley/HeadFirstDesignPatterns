using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class Light
    {
        public Light()
        {

        }

        public void on()
        {
            Console.WriteLine("Light is on");
        }

        public void off()
        {
            Console.WriteLine("Light is off");
        }
    }
}
