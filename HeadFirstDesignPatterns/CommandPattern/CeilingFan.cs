using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class CeilingFan
    {
        private string location = "";
        private int level;
        public static readonly int HIGH = 2;
        public static readonly int MEDIUM = 1;
        public static readonly int LOW = 0;

        public CeilingFan(string location)
        {
            this.location = location;
        }

        public void high()
        {
            level = HIGH;
            Console.WriteLine(location + " celing fan is on high");
        }

        public void medium()
        {
            level = MEDIUM;
            Console.WriteLine(location + " celing fan is on medium");
        }

        public void low()
        {
            level = LOW;
            Console.WriteLine(location + " ceiling fan is on low");
        }

        public void off()
        {
            level = 0;
            Console.WriteLine(location + " ceiling fan is off");
        }

        public int getSpeed()
        {
            return level;
        }
    }
}
