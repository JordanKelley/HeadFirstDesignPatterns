using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class CeilingFanLowCommand : Command
    {
        private CeilingFan ceilingFan;
        private int prevSpeed;

        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void execute()
        {
            prevSpeed = ceilingFan.getSpeed();
            ceilingFan.low();
        }

        public void undo()
        {
            if (prevSpeed == CeilingFan.HIGH)
            {
                ceilingFan.high();
            }
            else if (prevSpeed == CeilingFan.MEDIUM)
            {
                ceilingFan.medium();
            }
            else if (prevSpeed == CeilingFan.LOW)
            {
                ceilingFan.low();
            }
            else if (prevSpeed == CeilingFan.OFF)
            {
                ceilingFan.off();
            }
        }
    }
}
