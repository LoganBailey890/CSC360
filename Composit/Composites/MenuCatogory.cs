using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composit.Interfaces;

namespace Composit.Composites
{
    public class MenuCatogory : IMenu
    {
        string name;
        List<IMenu> menuItmes;

        public MenuCatogory(string name)
        {
            this.name = name;
            this.menuItmes = new List<IMenu>();
        }

        public void Add(IMenu menu)
        {
            this.menuItmes.Add(menu);
        }

        public void GetName()
        {
            Console.WriteLine(this.name);
            foreach (IMenu menu in menuItmes)
            {
                menu.GetName();
            }
        }

        public void Remove(IMenu menu)
        {
            this.menuItmes.Remove(menu);
        }
    }
}
