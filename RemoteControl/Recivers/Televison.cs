using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControl.Interfaces;

namespace RemoteControl.Recivers
{
    public class Televison : IElectronicDevice
    {
        private int volume = 0;


        public void Off()
        {
            Console.WriteLine("TV is off");
        }

        public void On()
        {
            Console.WriteLine("TV is on");
        }

        public void VolumeDown()
        {
            if (volume >= 0)
                volume--;
            Console.WriteLine("TV valume is at:" + volume);
        }

        public void VolumeUp()
        {
            volume++;
            Console.WriteLine("TV valume is at:" + volume);
        }
    }
}
