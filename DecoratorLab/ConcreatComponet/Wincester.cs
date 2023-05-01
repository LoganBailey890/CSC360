﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorLab.Interfaces;

namespace DecoratorLab.ConcreatComponet
{
    internal class Wincester : WeaponComponet
    {
        private int damage;

        public Wincester(int damage)
        {
            this.damage = damage;
        }

        public override string Description()
        {
            return "Wincester, with mods: ";
        }

        public override int Fire()
        {
            return damage;
        }

        public override string ImpaceDesc(int intImpact)
        {
            if (intImpact > 5)
                return "Thats a lot of damage";
            return "That is nothing but a scrace";
        }
    }
}
