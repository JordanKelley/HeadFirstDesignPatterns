using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.ObserverPattern
{
    public interface Observer
    {
        public void update(float temp, float humidity, float pressure);
    }
}
