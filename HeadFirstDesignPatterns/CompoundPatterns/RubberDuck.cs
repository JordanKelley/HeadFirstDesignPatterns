using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CompoundPatterns
{
    public class RubberDuck : Quackable
    {
        Observable observable;

        public RubberDuck()
        {
            observable = new Observable(this);
        }

        public void quack()
        {
            Console.WriteLine("Squek");
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
            return "Rubber Duck";
        }
    }
}
