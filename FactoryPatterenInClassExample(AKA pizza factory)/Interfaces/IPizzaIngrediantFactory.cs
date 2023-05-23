using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterenInClassExample_AKA_pizza_factory_.Interfaces
{
    public interface IPizzaIngrediantFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        IChesse CreateChesse();
        IMeat CreatePepperonie();
        IVeggies CreateIVeggies();

    }
}
