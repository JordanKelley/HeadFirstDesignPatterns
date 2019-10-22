using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.FactoryPattern
{
    public interface PizzaIngredientFactory
    {
        public Dough createDough();
        public Sauce createSauce();
        public Cheese createCheese();
        public List<Veggies> createVeggies();
        public Pepperoni createPepperoni();
        public Clams createClam();
    }
}
