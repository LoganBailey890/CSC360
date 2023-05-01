using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorLab.Interfaces;

namespace DecoratorLab.ConcreatDecorator
{
    internal class Blue : Color
    {
        private WeaponComponet baseWeaponComponet;

        public Blue(WeaponComponet baseWeaponComponet) : base(baseWeaponComponet)
        {
            this.baseWeaponComponet = baseWeaponComponet;
        }

        public override int Fire()
        {
            return base.Fire() + 50;
        }

        public override string Description()
        {
            return base.Description() + "Color: blue";
        }
        public override string ImpaceDesc(int intImpact)
        {
            intImpact = intImpact + 4;
            return baseWeaponComponet.ImpaceDesc(intImpact);
        }


    }
}
