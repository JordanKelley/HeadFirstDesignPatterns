using System;
using System.Collections.Generic;

namespace HeadFirstDesignPatterns.IteratorPattern
{
    public class PancakeHouseMenuIterator : Iterator
    {
        List<MenuItem> menuItems;
        int position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> menuItems)
        {
            this.menuItems = menuItems;
        }

        public Object next()
        {
            MenuItem menuItem = menuItems[position];
            position++;
            return menuItem;
        }

        public bool hasNext()
        {
            if(position >= menuItems.Count)
            {
                return false;
            }
            return true;
        }
    }
}
