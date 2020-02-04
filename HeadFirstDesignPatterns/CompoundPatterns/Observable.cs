using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CompoundPatterns
{
    public class Observable : QuackObservable
    {
        List<Observer> observers = new List<Observer>();
        QuackObservable duck;

        public Observable(QuackObservable duck)
        {
            this.duck = duck;
        }

        public void registerObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void notifyObservers()
        {
            var enumerator = observers.GetEnumerator();

            while(enumerator.MoveNext())
            {
                Observer observer = enumerator.Current;
                observer.update(duck);
            }
        }
    }
}
