using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.StatePattern
{
    public class NoQuarterState : State 
    {
        GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumballMachine.setState(gumballMachine.getHasQuarterState());
        }

        public void ejectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned, but there is no quarter");
        }

        public void dispense()
        {
            Console.WriteLine("You need to pay first");
        }
    }
}
