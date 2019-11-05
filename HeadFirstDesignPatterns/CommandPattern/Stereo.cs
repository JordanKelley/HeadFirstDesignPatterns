using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class Stereo
    {
        private string location;

        public Stereo(string location)
        {
            this.location = location;
        }

        public void on()
        {
            Console.WriteLine(location + " stereo is on");
        }

        public void off()
        {
            Console.WriteLine(location + " stereo is off");
        }

        public void setCD()
        {
            Console.WriteLine(location + " stereo is set for CD input");
        }

        public void setDVD()
        {
            Console.WriteLine(location + " stereo is set for DVD input");
        }

        public void setRadio()
        {
            Console.WriteLine(location + " stereo is set for Radio");
        }

        public void setVolume(int volume)
        {
            Console.WriteLine(location + " stereo volume set to " + volume);
        }
    }
}
