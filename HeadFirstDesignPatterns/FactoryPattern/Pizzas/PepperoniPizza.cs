using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.FactoryPattern
{
    public class PepperoniPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;
        public PepperoniPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        public override void prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            pepperoni = ingredientFactory.createPepperoni();
        }
    }
}
