using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorLab1.Interfaces1;

namespace DecoratorLab1.ConcreteDecorators
{
    internal class Lettece : Fillers
    {
        private Food baseFood;

        public Lettece(Food baseFood) : base(baseFood)
        {
            this.baseFood = baseFood;
        }

        public override string Descriptor()
        {
            return this.baseFood.Descriptor() + " Added Lettece";
        }

        public override string Flavor(int flavorImpact)
        {
            flavorImpact = flavorImpact - 1;
            return baseFood.Flavor(flavorImpact);
        }

        public override float priceDisplay()
        {
            return base.priceDisplay() + 1.25f;
        }
    }
}
