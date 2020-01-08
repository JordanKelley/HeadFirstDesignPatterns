﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.FacadePattern
{
    public class HomeTheaterFacade
    {
        private Amplifier amp;
        private Tuner tuner;
        private DvdPlayer dvd;
        private CdPlayer cd;
        private Projector projector;
        private TheaterLights lights;
        private Screen screen;
        private PopcornPopper popper;

        public HomeTheaterFacade(Amplifier amp,
            Tuner tuner,
            DvdPlayer dvd,
            CdPlayer cd,
            Projector projector,
            Screen screen,
            TheaterLights lights,
            PopcornPopper popper)
        {
            this.amp = amp;
            this.tuner = tuner;
            this.dvd = dvd;
            this.cd = cd;
            this.projector = projector;
            this.screen = screen;
            this.lights = lights;
            this.popper = popper;
        }

        public void watchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            popper.on();
            popper.pop();
            lights.dim(10);
            screen.down();
            projector.on();
            projector.wideScreenMode();
            amp.on();
            amp.setDvd(dvd);
            amp.setSurroundSound();
            amp.setVolume(5);
            dvd.on();
            dvd.play(movie);
        }

        public void endMovie()
        {
            Console.WriteLine("Shutting movie theater down... ");
            popper.off();
            lights.on();
            screen.up();
            projector.off();
            amp.off();
            dvd.stop();
            dvd.eject();
            dvd.off();
        }
    }
}
