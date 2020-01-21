using System;

namespace HeadFirstDesignPatterns.CompositePattern
{
    public abstract class MenuComponent
    {
        public virtual void add(MenuComponent menuComponent)
        {
            throw new Exception("Unsupported operation");
        }

        public virtual void remove(MenuComponent menuComponent)
        {
            throw new Exception("Unsupported operation");
        }

        public virtual MenuComponent getChild(int i)
        {
            throw new Exception("Unsupported operation");
        }

        public virtual string getName()
        {
            throw new Exception("Unsupported operation");
        }

        public virtual string getDescription()
        {
            throw new Exception("Unsupported operation");
        }

        public virtual double getPrice()
        {
            throw new Exception("Unsupported operation");
        }

        public virtual bool isVegetarian()
        {
            throw new Exception("Unsupported operation");
        }

        public virtual void print()
        {
            throw new Exception("Unsupported operation");
        }
    }
}
