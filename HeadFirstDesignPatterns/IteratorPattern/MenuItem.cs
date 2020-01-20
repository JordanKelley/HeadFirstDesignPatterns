using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.IteratorPattern
{
    public class MenuItem
    {
        string name;
        string description;
        bool vegetarian;
        double price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public string getName()
        {
            return name;
        }

        public string getDescription()
        {
            return description;
        }

        public double getPrice()
        {
            return price;
        }

        public bool isVegetarian()
        {
            return vegetarian;
        }
    }
}
