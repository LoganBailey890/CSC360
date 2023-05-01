using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControl.Interfaces;

namespace RemoteControl.Recivers
{
    public class TurnDeviceOff : ICommand
    {
        IElectronicDevice _device;

        public TurnDeviceOff(IElectronicDevice newDevice)
        {
            _device = newDevice;
        }

        public void Execute()
        {
            _device.Off();
        }

        public void Undo()
        {
            _device.On();
        }
    }
}
