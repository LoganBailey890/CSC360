using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControl.Interfaces;

namespace RemoteControl.Commands
{
    internal class TurnAllOff : ICommand
    {
        List<IElectronicDevice> _devices;

        public TurnAllOff(List<IElectronicDevice> alldevices)
        {
            this._devices = alldevices;
        }

        public void Execute()
        {
            _devices.ForEach(device => device.Off());
        }

        public void Undo()
        {
            _devices.ForEach(device => device.On());
        }
    }
}
