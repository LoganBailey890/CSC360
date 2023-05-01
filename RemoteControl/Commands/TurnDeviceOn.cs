using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControl.Interfaces;

namespace RemoteControl.Commands
{
    public class TurnDeviceOn : ICommand
    {
        IElectronicDevice _device;

        public TurnDeviceOn(IElectronicDevice newDevice)
        {
           this._device = newDevice;
        }

        public void Execute()
        {
            _device.On();
        }

        public void Undo()
        {
            _device.Off();
        }
    }
}
