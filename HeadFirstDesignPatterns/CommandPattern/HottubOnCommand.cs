using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class HottubOnCommand : Command
    {
        private Hottub hottub;

        public HottubOnCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }

        public void execute()
        {
            hottub.on();
        }

        public void undo()
        {
            hottub.off();
        }
    }
}
