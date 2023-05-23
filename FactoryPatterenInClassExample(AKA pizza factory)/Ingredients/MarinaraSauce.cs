using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatterenInClassExample_AKA_pizza_factory_.Interfaces;

namespace FactoryPatterenInClassExample_AKA_pizza_factory_.Ingredients
{
    public class MarinaraSauce : ISauce
    {
        public string GetName()
        {
            return "Marinar sauce";
        }
    }
}
