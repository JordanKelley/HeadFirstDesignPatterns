using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.TemplatePattern
{
    public abstract class CaffeineBeverage
    {
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            addCondiments();
        }

        abstract public void brew();

        abstract public void addCondiments();

        public void boilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
