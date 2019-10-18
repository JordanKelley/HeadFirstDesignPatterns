using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.FactoryPattern
{
    public class CheesePizza : Pizza
    {
        private PizzaIngredientFactory ingredientFactory;
        public CheesePizza(PizzaIngredientFactory pizzaIngredientFactory)
        {
            this.ingredientFactory = pizzaIngredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
        }
    }
}
