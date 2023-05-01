using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorLab1.Interfaces1;

namespace DecoratorLab1.ConcreteDecorators
{
    internal class Beef : Meats
    {
        private Food baseFood;

        public Beef(Food baseFood) : base(baseFood)
        {
            this.baseFood = baseFood;
        }

        public override string Descriptor()
        {
            return this.baseFood.Descriptor() + " Meat selection: Beef";
        }

        public override string Flavor(int flavorImpact)
        {
            flavorImpact = flavorImpact + 5;
            return baseFood.Flavor(flavorImpact);
        }

        public override float priceDisplay()
        {
            return base.priceDisplay() + 5f;
        }
    }
}
