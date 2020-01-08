using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.FacadePattern
{
    public class DvdPlayer
    {
        private string description;
        private int currentTrack;
        private Amplifier amplifier;
        private string movie;

        public DvdPlayer(string description, Amplifier amplifier)
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
            movie = null;
            Console.WriteLine(description + " eject");
        }

        public void play(string movie)
        {
            this.movie = movie;
            currentTrack = 0;
            Console.WriteLine(description + " playing \"" + movie + "\"");
        }

        public void play(int track)
        {
            if(movie == null)
            {
                Console.WriteLine(description + " can't play track " + track + " no dvd inserted");
            }
            else
            {
                currentTrack = track;
                Console.WriteLine(description + " playing track " + currentTrack + " of \"" + movie + "\"");
            }
        }

        public void stop()
        {
            currentTrack = 0;
            Console.WriteLine(description + " stopped \"" + movie + "\"");
        }

        public void pause()
        {
            Console.WriteLine(description + " paused \"" + movie + "\"");
        }

        public void setTwoChannelAudio()
        {
            Console.WriteLine(description + " set two channel audio");
        }

        public void setSurroundAudio()
        {
            Console.WriteLine(description + " set surround audio");
        }

        public override string ToString()
        {
            return description;
        }
    }
}
