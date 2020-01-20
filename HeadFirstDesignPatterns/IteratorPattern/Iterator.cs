using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.IteratorPattern
{
    public interface Iterator
    {
        public bool hasNext();
        public Object next();
    }
}
