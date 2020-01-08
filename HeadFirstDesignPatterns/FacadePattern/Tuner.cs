using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.FacadePattern
{
    public class Tuner
    {
        private string description;
        private Amplifier amplifier;
        private double frequency;

        public Tuner(string description, Amplifier amplifier)
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

        public void setFrequency(double frequency)
        {
            Console.WriteLine(description + " setting frequency to " + frequency);
            this.frequency = frequency;
        }

        public void setAm()
        {
            Console.WriteLine(description + " setting AM mode");
        }

        public void setFm()
        {
            Console.WriteLine(description + " setting FM mode");
        }

        public override string ToString()
        {
            return description;
        }
    }
}
