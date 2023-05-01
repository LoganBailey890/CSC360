using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoraBagpackIterator.Interface
{
    public interface IinventoryAgg
    {
        Iinventoryitoratetor GetIterator();
        void AddItem(Iitem item);
        void SwipeItem(Iitem iitem);
    }
}
