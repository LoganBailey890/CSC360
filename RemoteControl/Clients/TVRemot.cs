using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControl.Interfaces;
using RemoteControl.Recivers;

namespace RemoteControl.Clients
{
    internal class TVRemot
    {
        public static IElectronicDevice GetDevice()
        {
            return new Televison();
        }
    }
}
