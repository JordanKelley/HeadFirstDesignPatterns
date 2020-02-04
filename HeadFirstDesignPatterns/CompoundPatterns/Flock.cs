using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CompoundPatterns
{
    public class Flock : Quackable
    {
        List<Quackable> quackers = new List<Quackable>();

        public void add(Quackable quacker)
        {
            quackers.Add(quacker);
        }

        public void quack()
        {
            var enumerator = quackers.GetEnumerator();

            while(enumerator.MoveNext())
            {
                Quackable quacker = enumerator.Current;
                quacker.quack();
            }
        }

        public void registerObserver(Observer observer)
        {
            var enumerator = quackers.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Quackable duck = enumerator.Current;
                duck.registerObserver(observer);
            }
        }

        public void notifyObservers()
        {

        }

        public override string ToString()
        {
            return "Flock of Ducks";
        }
    }
}
