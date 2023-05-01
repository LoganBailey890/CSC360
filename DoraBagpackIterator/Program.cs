using DoraBagpackIterator.Interface;
using DoraBagpackIterator.Items;
using DoraBagpackIterator.ConcreatAggergate;

namespace DoraBagpackIterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IinventoryAgg backpack = new BagPackInventory();
            backpack.AddItem(new Book("1984"));
            backpack.AddItem(new Book("Ruin of kings"));
            Map _map = new Map();
            backpack.AddItem(_map);
            Torch _tourch = new Torch();
            backpack.AddItem(_tourch);
            backpack.SwipeItem(_map);
            Console.WriteLine("-----------BackPack-----------");

            Iinventoryitoratetor _backpackIntorator = backpack.GetIterator();
            while(_backpackIntorator.hasNext())
            {
                Console.WriteLine(_backpackIntorator.current()?.Name());
                _backpackIntorator.Next();
            }


            Console.WriteLine("----------------Hands----------------");
            IinventoryAgg hands = new HandsInventory();
            hands.AddItem(_map);
            hands.AddItem(_tourch);
            hands.AddItem(new Book("Minecraft handbook"));
            hands.SwipeItem(_map);


            Iinventoryitoratetor handsterator = hands.GetIterator();
            while (handsterator.hasNext())
            {
                Console.WriteLine(handsterator.current()?.Name());
                handsterator.Next();
            }

        }
    }

}

