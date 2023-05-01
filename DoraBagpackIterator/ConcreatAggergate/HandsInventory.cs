using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoraBagpackIterator.Interface;
using DoraBagpackIterator.ConcreatSomthing;
namespace DoraBagpackIterator.ConcreatAggergate
{
    public class HandsInventory : IinventoryAgg
    {
        public Iitem? LeftHand { get; set; }
        public Iitem? RightHand { get; set; }

        public void AddItem(Iitem newitem)
        {
            if (this.LeftHand == null)
            {
                this.LeftHand = newitem;
            }
            else if (this.RightHand == null)
            {
                this.RightHand = newitem;
            }
            else
            {
                this.RightHand = this.LeftHand;
                this.LeftHand = newitem;
            }
        }

        public Iinventoryitoratetor GetIterator()
        {
            return new HandInterator(this);
        }

        public void SwipeItem(Iitem _item)
        {
            if(this.LeftHand == _item)
            {
                this.LeftHand = null;
            }
            if(this.RightHand == _item)
            {
                this.RightHand = null;
            }
        }
    }
}
