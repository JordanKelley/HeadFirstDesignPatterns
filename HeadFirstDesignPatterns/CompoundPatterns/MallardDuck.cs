using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CompoundPatterns
{
    public class MallardDuck : Quackable
    {
        Observable observable;

        public MallardDuck()
        {
            observable = new Observable(this);
        }

        public void quack()
        {
            Console.WriteLine("Quack");
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
    }
}
