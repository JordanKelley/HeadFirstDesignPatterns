using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CompoundPatterns
{
    public class DuckCall : Quackable
    {
        Observable observable;

        public DuckCall()
        {
            observable = new Observable(this);
        }

        public void quack()
        {
            Console.WriteLine("Kwak");
            notifyObservers();
        }

        public void registerObserver(Observer observer)
        {
            observable.registerObserver(observer);
        }

        public void notifyObservers()
        {
            observable.notifyObservers();
        }

        public override string ToString()
        {
            return "Duck Call";
        }
    }
}
