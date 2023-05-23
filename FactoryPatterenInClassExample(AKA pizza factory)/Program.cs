using FactoryPatterenInClassExample_AKA_pizza_factory_.Interfaces;
using FactoryPatterenInClassExample_AKA_pizza_factory_.Stores;
using FactoryPatterenInClassExample_AKA_pizza_factory_.Pizzas;
using System;
using System.Collections.Generic;

namespace PizzaFactoryInClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> orderedPizzas = new List<Pizza>();
            PizzaStore nyPizzaStore = new NeyYorkPizzaStore();
            orderedPizzas.Add(nyPizzaStore.OrderPizza("Chesse"));
            orderedPizzas.Add(nyPizzaStore.OrderPizza("Veggies"));

            PizzaStore chicagoPizza = new ChicagoPizzaStore();
            orderedPizzas.Add(chicagoPizza.OrderPizza("Chesse"));
            orderedPizzas.Add(chicagoPizza.OrderPizza("Veggies"));
            foreach (var pizza in orderedPizzas)
            {
                printPizza(pizza);
            }

        }

        static void printPizza(Pizza orderPizza)
        {
            Console.WriteLine(orderPizza.GetName());
            Console.WriteLine("----------- Ingredients---------------");
            foreach (var ingredints in orderPizza.GetIngredents())
            {
                Console.WriteLine(ingredints);
            }
            Console.WriteLine("");
        }
    }
}