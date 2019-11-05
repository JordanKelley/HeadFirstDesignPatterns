using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class RemoteControl
    {
        private Command[] onCommands;
        private Command[] offCommands;

        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];

            Command noCommand = new NoCommand();

            for(int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].execute();
        }

        public void offButton(int slot)
        {
            offCommands[slot].execute();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n------ Remote Control -------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuilder.Append("[slot " + i + "] " + onCommands[i].GetType().Name
                    + "    " + offCommands[i].GetType().Name + "\n");
            }
            return stringBuilder.ToString();
        }
    }
}
