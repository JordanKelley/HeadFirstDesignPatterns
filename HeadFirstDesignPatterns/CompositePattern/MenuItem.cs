using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CompositePattern
{
    public class MenuItem : MenuComponent
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

        public override string getName()
        {
            return name;
        }

        public override string getDescription()
        {
            return description;
        }

        public override double getPrice()
        {
            return price;
        }

        public override bool isVegetarian()
        {
            return vegetarian;
        }

        public override void print()
        {
            Console.Write("  " + getName());
            if(isVegetarian())
            {
                Console.Write("(v)");
            }
            Console.WriteLine(", " + getPrice());
            Console.WriteLine("    -- " + getDescription());
        }
    }
}
