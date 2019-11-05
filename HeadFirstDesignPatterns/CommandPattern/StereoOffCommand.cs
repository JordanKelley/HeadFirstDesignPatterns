using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CommandPattern
{
    public class StereoOffCommand : Command
    {
        private Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.off();
        }
    }
}
