using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControl.Interfaces;

namespace RemoteControl.Recivers
{
    public class Radio : IElectronicDevice
    {
        private int volume = 0;


        public void Off()
        {
            Console.WriteLine("Radio is off");
        }

        public void On()
        {
            Console.WriteLine("Radio is on");
        }

        public void VolumeDown()
        {
            if (volume >= 0)
                volume--;
            Console.WriteLine("Radio valume is at:" + volume);
        }

        public void VolumeUp()
        {
            volume++;
            Console.WriteLine("Radio valume is at:" + volume);
        }
    }
}
