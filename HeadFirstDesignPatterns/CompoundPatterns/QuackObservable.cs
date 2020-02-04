using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CompoundPatterns
{
    public interface QuackObservable
    {
        public void registerObserver(Observer observer);
        public void notifyObservers();
    }
}
