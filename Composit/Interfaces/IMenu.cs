using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composit.Interfaces
{
    public interface IMenu
    {
        void GetName();
        void Add(IMenu menu);
        void Remove(IMenu menu);
    }
}
