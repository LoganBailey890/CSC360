using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLab.Interfaces
{
    abstract class Mod : WeaponComponet
    {
        private WeaponComponet baseWeaponComponet;

        public Mod(WeaponComponet baseWeaponComponet)
        {
            this.baseWeaponComponet = baseWeaponComponet;
        }

        public override int Fire()
        {
            return this.baseWeaponComponet.Fire();
        }

        public override string Description()
        {
            return this.baseWeaponComponet.Description();
        }
    }
}
