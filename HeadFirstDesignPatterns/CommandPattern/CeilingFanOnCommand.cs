using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class CeilingFanOnCommand : Command
    {
        private CeilingFan ceilingFan;

        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void execute()
        {
            ceilingFan.high();
        }
    }
}
