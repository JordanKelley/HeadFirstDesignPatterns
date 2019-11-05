using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class GarageDoor
    {
        private string location;
        public GarageDoor(string location) 
        {
            this.location = location;
        }

        public void up()
        {
            Console.WriteLine(location + "Garage Door is open");
        }

        public void down()
        {
            Console.WriteLine(location + "Garage Door is closed");
        }

        public void stop()
        {
            Console.WriteLine(location + "Garage Door is stopped");
        }

        public void lightOn()
        {
            Console.WriteLine(location + "Garage light is on");
        }

        public void lightOff()
        {
            Console.WriteLine(location + "Garage light is off");
        }
    }
}
