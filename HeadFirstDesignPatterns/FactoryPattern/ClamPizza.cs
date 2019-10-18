using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.FactoryPattern
{
    public class ClamPizza : Pizza
    {
        private PizzaIngredientFactory pizzaIngredientFactory;
        public ClamPizza(PizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = pizzaIngredientFactory.createDough();
            sauce = pizzaIngredientFactory.createSauce();
            cheese = pizzaIngredientFactory.createCheese();
            clam = pizzaIngredientFactory.createClam();
        }
    }
}
