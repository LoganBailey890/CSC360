using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControl.Interfaces;

namespace RemoteControl.Commands
{
    public class TurnVolumUp : ICommand
    {
        IElectronicDevice _device;

        public TurnVolumUp(IElectronicDevice newDevice)
        {
            this._device = newDevice;
        }

        public void Execute()
        {
            _device.VolumeUp();
        }

        public void Undo()
        {
            _device.VolumeDown();
        }
    }
}
