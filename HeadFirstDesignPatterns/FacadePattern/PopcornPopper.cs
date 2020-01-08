using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.FacadePattern
{
    public class PopcornPopper
    {
        private string description;

        public PopcornPopper(string description)
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

        public void pop()
        {
            Console.WriteLine(description + " popping popcorn!");
        }

        public override string ToString()
        {
            return description;
        }
    }
}
