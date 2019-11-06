using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class CeilingFan
    {
        private string location = "";
        private int speed;
        public static readonly int HIGH = 3;
        public static readonly int MEDIUM = 2;
        public static readonly int LOW = 1;
        public static readonly int OFF = 0;

        public CeilingFan(string location)
        {
            this.location = location;
        }

        public void high()
        {
            speed = HIGH;
            Console.WriteLine(location + " celing fan is on high");
        }

        public void medium()
        {
            speed = MEDIUM;
            Console.WriteLine(location + " celing fan is on medium");
        }

        public void low()
        {
            speed = LOW;
            Console.WriteLine(location + " ceiling fan is on low");
        }

        public void off()
        {
            speed = OFF;
            Console.WriteLine(location + " ceiling fan is off");
        }

        public int getSpeed()
        {
            return speed;
        }
    }
}
