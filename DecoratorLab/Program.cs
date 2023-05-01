using System;
using DecoratorLab.Interfaces;
using DecoratorLab.ConcreatComponet;
using DecoratorLab.ConcreatDecorator;

namespace DecoratorLab
{
    class Program
    {
        static void Main(string[] args)
        {
            WeaponComponet gun = new P902(10);

            gun = new Barrel(gun);
            gun = new Blue(gun);

            Console.WriteLine("This" + gun.Description() + gun.Fire() + " damage");
            Console.WriteLine(gun.ImpaceDesc(7));

            WeaponComponet wincester = new Wincester(20);
        }
    }
}
