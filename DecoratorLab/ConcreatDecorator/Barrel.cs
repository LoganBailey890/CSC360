using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorLab.Interfaces;

namespace DecoratorLab.ConcreatDecorator
{
    internal class Barrel : Color
    {
        private WeaponComponet baseWeaponComponet;

        public Barrel(WeaponComponet baseWeaponComponet) : base( baseWeaponComponet)
        {
            this.baseWeaponComponet = baseWeaponComponet;
        }

        public override int Fire()
        {
            return base.Fire() + 5;
        }

        public override string Description()
        {
            return this.baseWeaponComponet.Description() + " Barrel";
        }
        public override string ImpaceDesc(int intImpact)
        {
            intImpact = intImpact + 4;
            return baseWeaponComponet.ImpaceDesc(intImpact);
        }
    }
}
