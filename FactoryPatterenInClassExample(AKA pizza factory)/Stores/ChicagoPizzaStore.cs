using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatterenInClassExample_AKA_pizza_factory_.Pizzas;
using FactoryPatterenInClassExample_AKA_pizza_factory_.Ingredients;
using FactoryPatterenInClassExample_AKA_pizza_factory_.Interfaces;
using FactoryPatterenInClassExample_AKA_pizza_factory_.Factories;

namespace FactoryPatterenInClassExample_AKA_pizza_factory_.Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            IPizzaIngrediantFactory ingrediantFactory = new ChicagoPizzaFactory();

            switch (type)
            {
                case "Veggies":
                    pizza = new VeggiePizza(ingrediantFactory);
                    pizza.SetName("Chiago Style Vegggie pizza");
                    break;
                case "Chesse":
                    pizza = new ChessePizza(ingrediantFactory);
                    pizza.SetName("Chiago Style Chesse pizza");
                    break;
            }
            return pizza;
        }
    }
}
