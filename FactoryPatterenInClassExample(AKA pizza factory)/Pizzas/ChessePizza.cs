using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatterenInClassExample_AKA_pizza_factory_.Interfaces;

namespace FactoryPatterenInClassExample_AKA_pizza_factory_.Pizzas
{
    public class ChessePizza : Pizza
    {
        private IPizzaIngrediantFactory _ingrediantFactory;

        public ChessePizza(IPizzaIngrediantFactory _ingrediantsFactory)
        {
           this._ingrediantFactory = _ingrediantsFactory;
        }
        public override void Prepare()
        {
            this.dough = this._ingrediantFactory.CreateDough();
            this.sauce = this._ingrediantFactory.CreateSauce();
            this.chesse = this._ingrediantFactory.CreateChesse();
        }
    }
}
