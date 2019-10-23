using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class GarageDoor
    {
        public GarageDoor() { }

        public void up()
        {
            Console.WriteLine("Garage Door is open");
        }

        public void down()
        {
            Console.WriteLine("Garage Door is closed");
        }

        public void stop()
        {
            Console.WriteLine("Garage Door is stopped");
        }

        public void lightOn()
        {
            Console.WriteLine("Garage light is on");
        }

        public void lightOff()
        {
            Console.WriteLine("Garage light is off");
        }
    }
}
