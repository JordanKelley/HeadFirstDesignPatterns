using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class TV
    {
        private string location;
        private int channel;

        public TV(string location)
        {
            this.location = location;
        }

        public void on()
        {
            Console.WriteLine(location + " TV is on");
        }

        public void off()
        {
            Console.WriteLine(location + " TV is off");
        }

        public void setInputChannel()
        {
            this.channel = 3;
            Console.WriteLine(location + " TV channel is set for DVD");
        }
    }
}
