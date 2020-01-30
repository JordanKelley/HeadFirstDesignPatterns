using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.StatePattern
{
    public class SoldOutState : State
    {
        GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            Console.WriteLine("Sold out, cannot dispense");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Can't eject, no quarter has been inserted");
        }

        public void insertQuarter()
        {
            Console.WriteLine("Cannot insert quarter, machine is sold out");
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned, but their are no gumballs");
        }
    }
}
