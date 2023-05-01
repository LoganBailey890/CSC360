using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoraBagpackIterator.Interface;
using DoraBagpackIterator.ConcreatAggergate;
namespace DoraBagpackIterator.ConcreatSomthing
{
    public class BackPackIterator : Iinventoryitoratetor
    {
        BagPackInventory backpack;
        private int index = 0;
        public BackPackIterator(BagPackInventory inventory)
        {
            this.backpack = inventory;
        }

        public Iitem? current()
        {
            return this.backpack.lstInventory[index];
        }

        public bool hasNext()
        {
            return this.index < this.backpack.lstInventory.Count;
        }

        public void Next()
        {
            this.index++;
        }

    }
}
