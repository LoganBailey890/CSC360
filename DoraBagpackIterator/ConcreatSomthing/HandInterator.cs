using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoraBagpackIterator.Interface;
using DoraBagpackIterator.ConcreatAggergate;
namespace DoraBagpackIterator.ConcreatSomthing
{
    public class HandInterator : Iinventoryitoratetor
    {
        HandsInventory _inventory;
        int index = 0;
        public HandInterator(HandsInventory inInventory)
        {
            _inventory = inInventory;
        }

        public Iitem? current()
        {
            switch (this.index)
            {
                case 0:
                    return _inventory.LeftHand;
                case 1:
                    return _inventory.RightHand;
                default:
                    return null;
            }
        }

        public bool hasNext()
        {
            return this.index == 0 || this.index == 1; 
        }

        public void Next()
        {
            this.index++;
        }
    }
}
