using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorLab1.Interfaces1;

namespace DecoratorLab1.ConcreteDecorators
{
    internal class Bacon : Meats
    {
        private Food baseFood;

        public Bacon(Food baseFood) : base(baseFood)
        {
            this.baseFood = baseFood;
        }

        public override string Descriptor()
        {
            return this.baseFood.Descriptor() + " Meat selection: Bacon";
        }

        public override string Flavor(int flavorImpact)
        {
            flavorImpact = flavorImpact + 4;
            return baseFood.Flavor(flavorImpact);
        }

        public override float priceDisplay()
        {
            return base.priceDisplay() + 4.99f;
        }
    }
}
