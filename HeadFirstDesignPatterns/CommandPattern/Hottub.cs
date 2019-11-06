using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class Hottub
    {
        private bool isOn;
        private int temperature;

        public Hottub()
        {

        }

        public void on()
        {
            isOn = true;
        }

        public void off()
        {
            isOn = false;
        }

        public void circulate()
        {
            if(isOn)
            {
                Console.WriteLine("Hot tub is bubbling");
            }
        }

        public void jetsOn()
        {
            if(isOn)
            {
                Console.WriteLine("Hot tub jets are on");
            }
        }

        public void jetsOff()
        {
            if(isOn)
            {
                Console.WriteLine("Hottub jets are off");
            }
        }

        public void setTemperature(int temperature)
        {
            if(temperature > this.temperature)
            {
                Console.WriteLine("Hot tub is heating to a steaming " + temperature + " degrees");
            }
            else
            {
                Console.WriteLine("Hot tub is cooling to " + temperature + " degrees");
            }
            this.temperature = temperature;
        }
    }
}
