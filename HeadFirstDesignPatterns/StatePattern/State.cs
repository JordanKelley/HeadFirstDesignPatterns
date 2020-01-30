using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.StatePattern
{
    public interface State
    {
        public void insertQuarter();
        public void ejectQuarter();
        public void turnCrank();
        public void dispense();
    }
}
