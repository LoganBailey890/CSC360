using Composit.Composites;
using Composit.Interfaces;
using Composit.Leaf;

namespace Composit
{
    public class Program
    { 
        static void Main(string[] args)
        {
            IMenu menu = new MenuCatogory("Menu");
            IMenu menu1 = new MenuCatogory("Burgers");

            menu1.Add(new MenuItem("Classic Burger"));

            IMenu subCategory = new MenuCatogory("Spicy");
            subCategory.Add(new MenuItem("Jalepeno Burger"));
            subCategory.Add(new MenuItem("Chill Burger"));
            menu1.Add(subCategory);
            menu.Add(menu1);
            menu.GetName();

            IMenu menu2 = new MenuCatogory("Soups");
            menu2.Add(new MenuItem("Broccoli and cheese"));
            menu2.Add(new MenuItem("Chicken Noodle"));
            menu.Add(menu2);
            menu.GetName();


        }
    }


}

