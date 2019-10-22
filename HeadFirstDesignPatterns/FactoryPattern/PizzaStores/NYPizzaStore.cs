using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.FactoryPattern
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if(type.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("New York Style Cheese Pizza");
            }
            else if(type.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.setName("New York Style Veggie Pizza");
            }
            else if(type.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("New York Style Clam Pizza");
            }
            else if(type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.setName("New York Style Pepperoni Pizza");
            }
            return pizza;
        }
    }
}
