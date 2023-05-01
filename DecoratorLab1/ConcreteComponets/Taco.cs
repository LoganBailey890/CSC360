using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorLab1.Interfaces1;

namespace DecoratorLab1.ConcreteComponets
{
    internal class Taco : Food
    {
        private float price;

        public Taco(float price)
        {
            this.price = price;
        }

        public override string Descriptor()
        {
            return "Taco, with: ";
        }

        public override string Flavor(int flavorImpact)
        {
            if (flavorImpact > 7)
                return "That was good";
            return "That was not worth the money";
        }

        public override float priceDisplay()
        {
            return price;
        }
    }
}
