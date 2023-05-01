using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControl.Interfaces;

namespace RemoteControl.Commands
{
    public class TurnDeviceDown : ICommand
    {
        IElectronicDevice _device;

        public TurnDeviceDown(IElectronicDevice newDevice)
        {
            this._device = newDevice;
        }

        public void Execute()
        {
            _device.VolumeDown();
        }

        public void Undo()
        {
            _device.VolumeUp();
        }
    }
}

