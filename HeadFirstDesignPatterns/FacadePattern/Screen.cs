using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.FacadePattern
{
    public class Screen
    {
        private string description;

        public Screen(string description)
        {
            this.description = description;
        }

        public void up()
        {
            Console.WriteLine(description + " going up");
        }

        public void down()
        {
            Console.WriteLine(description + " going down");
        }

        public override string ToString()
        {
            return description;
        }
    }
}
