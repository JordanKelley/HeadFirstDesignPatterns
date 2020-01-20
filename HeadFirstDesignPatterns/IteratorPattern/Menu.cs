using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.IteratorPattern
{
    public interface Menu
    {
        public Iterator createIterator();
    }
}
