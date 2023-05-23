using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatterenInClassExample_AKA_pizza_factory_.Pizzas;

namespace FactoryPatterenInClassExample_AKA_pizza_factory_.Stores
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            pizza.Prepare();
            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
