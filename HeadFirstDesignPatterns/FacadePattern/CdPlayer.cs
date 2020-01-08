using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.FacadePattern
{
    public class CdPlayer
    {
        private string description;
        private int currentTrack;
        private Amplifier amplifier;
        private string title; 

        public CdPlayer(string description, Amplifier amplifier)
        {
            this.description = description;
            this.amplifier = amplifier;
        }

        public void on()
        {
            Console.WriteLine(description + " on");
        }

        public void off()
        {
            Console.WriteLine(description + " off");
        }

        public void eject()
        {
            title = null;
            Console.WriteLine(description + " eject");
        }

        public void play(string title)
        {
            this.title = title;
            currentTrack = 0;
            Console.WriteLine(description + " playing \"" + title + "\"");
        }

        public void play(int track)
        {
            if(title == null)
            {
                Console.WriteLine(description + " can't play track " + track + ", no cd inserted");
            }
            else
            {
                currentTrack = track;
                Console.WriteLine(description + " playing track " + currentTrack);
            }
        }

        public void stop()
        {
            currentTrack = 0;
            Console.WriteLine(description + " stopped");
        }

        public void pause()
        {
            Console.WriteLine(description + " paused \"" + title + "\"");
        }

        public override string ToString()
        {
            return description;
        }
    }
}
