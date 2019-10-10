using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.ObserverPattern
{
    public interface Subject
    {
        public void registerObserver(Observer o);
        public void removeObserver(Observer o);
        public void notifyObservers();
    }
}
