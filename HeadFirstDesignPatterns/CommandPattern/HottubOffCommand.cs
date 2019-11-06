using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class HottubOffCommand : Command
    {
        private Hottub hottub;

        public HottubOffCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }

        public void execute()
        {
            hottub.off();
        }

        public void undo()
        {
            hottub.on();
        }
    }
}
