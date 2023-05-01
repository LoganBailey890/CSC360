using System;
using DecoratorLab1.ConcreteDecorators;
using DecoratorLab1.ConcreteComponets;
using DecoratorLab1.Interfaces1;
namespace DecoratorLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Food burrito = new Burrito(3.99f);
            burrito = new Beef(burrito);
            burrito = new Rice(burrito);
            burrito = new Chesse(burrito);

            Console.WriteLine(burrito.Descriptor() + " cost " + burrito.priceDisplay());
            Console.WriteLine(burrito.Flavor(3));

            Food taco = new Taco(2.99f);
            taco = new Chicken(taco);
            taco = new Chesse(taco);
            taco = new Lettece(taco);

            Console.WriteLine();
            Console.WriteLine(taco.Descriptor() + " cost " + taco.priceDisplay());

            Food combo = new CombonationPlate(5.99f);
            combo = new Bacon(combo);
            combo = new Lettece(combo);
            combo = new Eggs(combo);
            combo = new Rice(combo);
            Console.WriteLine();
            Console.WriteLine(combo.Descriptor() + " cost " + combo.priceDisplay());

        }
    }
}
