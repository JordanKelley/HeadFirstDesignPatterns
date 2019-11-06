using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class TVOffCommand : Command
    {
        private TV tv;

        public TVOffCommand(TV tv)
        {
            this.tv = tv;
        }

        public void execute()
        {
            tv.off();
        }

        public void undo()
        {
            tv.on();
        }
    }
}
