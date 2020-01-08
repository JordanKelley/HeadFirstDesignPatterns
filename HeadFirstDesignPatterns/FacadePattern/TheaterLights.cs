using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.FacadePattern
{
    public class TheaterLights
    {
        private string description;

        public TheaterLights(string description)
        {
            this.description = description;
        }

        public void on()
        {
            Console.WriteLine(description + " on");
        }

        public void off()
        {
            Console.WriteLine(description + " off");
        }

        public void dim(int level)
        {
            Console.WriteLine(description + " dimming to " + level + "%");
        }

        public override string ToString()
        {
            return description;
        }
    }
}
