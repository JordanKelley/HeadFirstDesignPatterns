using System;

namespace HeadFirstDesignPatterns.IteratorPattern
{
    public class DinerMenuIterator : Iterator
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public Object next()
        {
            MenuItem menuItem = items[position];
            position++;
            return menuItem;
        }

        public bool hasNext()
        {
            if (position >= items.Length || items[position] == null)
            {
                return false;
            }
            return true;
        }
    }
}
