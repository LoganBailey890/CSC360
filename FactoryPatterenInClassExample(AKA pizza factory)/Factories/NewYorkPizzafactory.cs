using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatterenInClassExample_AKA_pizza_factory_.Ingredients;
using FactoryPatterenInClassExample_AKA_pizza_factory_.Interfaces;

namespace FactoryPatterenInClassExample_AKA_pizza_factory_.Factories
{
    internal class NewYorkPizzafactory : IPizzaIngrediantFactory
    {
        public IChesse CreateChesse()
        {
            return new Mozzeral();
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public IVeggies CreateIVeggies()
        {
            return new BlackOlives();
        }

        public IMeat CreatePepperonie()
        {
            return new Pepperonie();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }
    }
}
