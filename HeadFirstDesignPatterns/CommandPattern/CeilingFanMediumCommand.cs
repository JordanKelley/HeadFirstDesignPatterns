using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class CeilingFanMediumCommand : Command
    {
        private CeilingFan ceilingFan;
        private int prevSpeed;

        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void execute()
        {
            prevSpeed = ceilingFan.getSpeed();
            ceilingFan.medium();
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
