using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatterenInClassExample_AKA_pizza_factory_.Interfaces;

namespace FactoryPatterenInClassExample_AKA_pizza_factory_.Pizzas
{
    public abstract class Pizza
    {
        public ISauce sauce;
        public IChesse chesse;
        public IMeat meat;
        public IVeggies veggies;
        public IDough dough;

        public string Name;

        public abstract void Prepare();
        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }

        public List<string> GetIngredents()
        {
            List<string> ingredients = new List<string>();
            if(dough !=null)
                ingredients.Add(this.dough.GetName());
            if (sauce != null)
                ingredients.Add(this.sauce.GetName());
            if (veggies != null)
                ingredients.Add(this.veggies.GetName());
            if (meat != null)
                ingredients.Add(this.meat.GetName());
            if (chesse != null)
                ingredients.Add(this.chesse.GetName());
            return ingredients;
        }

    }
}
