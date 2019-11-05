using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class CeilingFanOffCommand : Command
    {
        private CeilingFan ceilingFan;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void execute()
        {
            ceilingFan.off();
        }
    }
}
