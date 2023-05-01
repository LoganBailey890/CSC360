﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLab.Interfaces
{
    abstract class Color : WeaponComponet
    {
        private WeaponComponet baseWeaponComponet;

        public Color(WeaponComponet baseWeaponComponet)
        {
            this.baseWeaponComponet = baseWeaponComponet;
        }

        public override int Fire()
        {
            return this.baseWeaponComponet.Fire();
        }

        public override string Description()
        {
            return baseWeaponComponet.Description();
        }
  
    }
}