using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatterenInClassExample_AKA_pizza_factory_.Interfaces;
using FactoryPatterenInClassExample_AKA_pizza_factory_.Ingredients;

namespace FactoryPatterenInClassExample_AKA_pizza_factory_.Factories
{
    public class ChicagoPizzaFactory : IPizzaIngrediantFactory
    {
        public IChesse CreateChesse()
        {
            return new Mozzeral();
        }

        public IDough CreateDough()
        {
            return new ThickCrustDouch();
        }
        public IVeggies CreateIVeggies()
        {
            return new RedPepper();
        }

        public IMeat CreatePepperonie()
        {
            return new Pepperonie();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }
    }
}
