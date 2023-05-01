using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorLab1.Interfaces1;

namespace DecoratorLab1.ConcreteDecorators
{
    internal class Chesse : Fillers
    {
        private Food baseFood;

        public Chesse(Food baseFood) : base(baseFood)
        {
            this.baseFood = baseFood;
        }

        public override string Descriptor()
        {
            return this.baseFood.Descriptor() + " Added Chesse";
        }

        public override string Flavor(int flavorImpact)
        {
            flavorImpact = flavorImpact + 2;
            return baseFood.Flavor(flavorImpact);
        }

        public override float priceDisplay()
        {
            return base.priceDisplay() + 0.99f;
        }
    }
}
