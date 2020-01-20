using System.Collections.Generic;

namespace HeadFirstDesignPatterns.IteratorPattern
{
    public class PancakeHouseMenu
    {
        List<MenuItem> menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();

            addItem("K&B's Pancake Breakfast",
            "Pancakes with scrambled eggs, and toast",
            true,
            2.99);

            addItem("Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99);

            addItem("Blueberry Pancakes",
                "Pancakes made with fresh blueberries",
                true,
                3.49);

            addItem("Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true,
                3.59);
        }

        public void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }

        public Iterator createIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }
    }
}
