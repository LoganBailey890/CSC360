using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoraBagpackIterator.Interface;
using DoraBagpackIterator.ConcreatSomthing;
namespace DoraBagpackIterator.ConcreatAggergate
{
    public class BagPackInventory : IinventoryAgg
    {
        public List<Iitem> lstInventory;

        public BagPackInventory()
        {
            lstInventory = new List<Iitem>();
        }

        public void AddItem(Iitem item)
        {
            lstInventory.Add(item);
        }

        public Iinventoryitoratetor GetIterator()
        {
            return new BackPackIterator(this);
        }

        public void SwipeItem(Iitem theItem)
        {
            lstInventory.Remove(theItem);
        }
    }
}
