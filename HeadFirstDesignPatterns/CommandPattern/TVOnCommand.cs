using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class TVOnCommand : Command
    {
        private TV tv; 

        public TVOnCommand(TV tv)
        {
            this.tv = tv;
        }

        public void execute()
        {
            tv.on();
        }

        public void undo()
        {
            tv.off();
        }
    }
}
