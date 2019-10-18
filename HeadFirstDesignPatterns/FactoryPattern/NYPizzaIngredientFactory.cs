using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.FactoryPattern
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough createDough()
        {
            return new ThinCrustDough();
        }

        public Sauce createSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese createCheese()
        {
            return new ReggianoCheese();
        }

        public List<Veggies> createVeggies()
        {
            return new List<Veggies>() { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams createClam()
        {
            return new FreshClams();
        }
    }
}
