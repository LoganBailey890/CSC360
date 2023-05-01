using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoraBagpackIterator.Interface;

namespace DoraBagpackIterator.Items
{
    public class Book : Iitem
    {
        private string strItemName;

        public Book(string strItemName)
        {
            this.strItemName = strItemName;
        }

        public string Name()
        {
            return strItemName + " Book";
        }
    }
}
