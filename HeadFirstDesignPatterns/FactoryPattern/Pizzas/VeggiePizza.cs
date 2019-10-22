using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.FactoryPattern
{
    public class VeggiePizza : Pizza
    {
        private PizzaIngredientFactory ingredientFactory;
        public VeggiePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        public override void prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            veggies = ingredientFactory.createVeggies();
        }
    }
}
