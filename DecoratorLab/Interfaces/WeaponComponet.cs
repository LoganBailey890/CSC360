using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLab.Interfaces
{
    abstract class WeaponComponet
    {
        public abstract int Fire();

        public abstract string Description();

        public abstract string ImpaceDesc(int intImpact);

    }
}
