using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.TemplatePattern
{
    public class Duck : IComparable
    {
        String name;
        int weight;

        public Duck(String name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override String ToString()
        {
            return name + " weights " + weight;
        }

        public int CompareTo(Object obj)
        {
            Duck otherDuck = (Duck)obj;

            if(this.weight < otherDuck.weight)
            {
                return -1;
            }
            else if(this.weight == otherDuck.weight)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
