using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLab1.Interfaces1
{
    abstract class Meats : Food
    {
        private Food baseFood;

        public Meats(Food baseFood)
        {
            this.baseFood = baseFood;
        }

        public override float priceDisplay()
        {
            return this.baseFood.priceDisplay();
        }

        public override string Descriptor()
        {
            return this.baseFood.Descriptor();
        }

        public override string Flavor(int flavorImpact)
        {
            return this.baseFood.Flavor(flavorImpact);
        }
    }
}
