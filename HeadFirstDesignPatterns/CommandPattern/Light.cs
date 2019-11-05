using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class Light
    {
        private string location;
        public Light(string location)
        {
            this.location = location;
        }

        public void on()
        {
            Console.WriteLine(location + " light is on");
        }

        public void off()
        {
            Console.WriteLine(location + " light is off");
        }
    }
}
