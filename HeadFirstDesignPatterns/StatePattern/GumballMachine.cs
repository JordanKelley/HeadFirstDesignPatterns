using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.StatePattern
{
    public class GumballMachine
    {
        State soldOutState;
        State noQuarterState;
        State hasQuarterState;
        State soldState;
        State winnerState;

        State state;
        int count = 0;

        public GumballMachine(int numberGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);
            this.count = numberGumballs;

            if(numberGumballs > 0)
            {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }
        }

        public void insertQuarter()
        {
            state.insertQuarter();
        }

        public void ejectQuarter()
        {
            state.ejectQuarter();
        }

        public void turnCrank()
        {
            state.turnCrank();
            state.dispense();
        }

        internal void setState(State state)
        {
            this.state = state;
        }

        internal void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");

            if(count != 0)
            {
                count--;
            }
        }

        internal State getState()
        {
            return state;
        }

        internal State getSoldOutState()
        {
            return soldOutState;    
        }

        internal State getNoQuarterState()
        {
            return noQuarterState;
        }

        internal State getHasQuarterState()
        {
            return hasQuarterState;    
        }

        internal State getSoldState()
        {
            return soldState;
        }

        internal State getWinnerState()
        {
            return winnerState;
        }

        internal int getCount()
        {
            return count;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nJava-enabled Standing Gumball Model #2004");
            result.Append("\nInventory: " + count + " gumball");
            if (count != 1)
            {
                result.Append("s");
            }
            result.Append("\n");
            result.Append("Machine is " + state + "\n");
            return result.ToString();
        }
    }
}
