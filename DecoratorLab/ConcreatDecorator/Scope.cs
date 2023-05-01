using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorLab.Interfaces;

namespace DecoratorLab.ConcreatDecorator
{
    internal class Scope : Color
    {
        private WeaponComponet baseWeaponComponet;
        
        public Scope(WeaponComponet baseWeaponComponet) : base(baseWeaponComponet)
        {
            this.baseWeaponComponet = baseWeaponComponet;
        }

        public override int Fire()
        {
            return base.Fire() + 2;
        }

        public override string Description()
        {
            return this.baseWeaponComponet.Description() + " Scope";
        }

        public override string ImpaceDesc(int intImpact)
        {
            intImpact = intImpact + 4;
            return baseWeaponComponet.ImpaceDesc(intImpact);
        }
    }
}
