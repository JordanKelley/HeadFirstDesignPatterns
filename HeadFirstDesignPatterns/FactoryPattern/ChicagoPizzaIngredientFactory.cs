using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.FactoryPattern
{
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new Mozzarella();
        }

        public Clams createClam()
        {
            return new FrozenClams();
        }

        public Dough createDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce createSauce()
        {
            return new PlumTomatoSauce();
        }

        public List<Veggies> createVeggies()
        {
            return new List<Veggies>() { new Spinach(), new BlackOlives(), new Eggplant() };
        }
    }
}
