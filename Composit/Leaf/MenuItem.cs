using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composit.Interfaces;

namespace Composit.Leaf
{
    public class MenuItem : IMenu
    {
        string Name;

        public MenuItem(string name)
        {
            Name = name;
        }

        public void GetName()
        {
            Console.WriteLine(" - " + this.Name);
        }

        public void Add(IMenu menu)
        {
            throw new NotImplementedException();
        }

        public void Remove(IMenu menu)
        {
            throw new NotImplementedException();
        }
    }
}
