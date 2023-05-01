using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControl.Interfaces;

namespace RemoteControl.Invokers
{
    public class DeviceButton
    {
        ICommand theCommand;

        public DeviceButton(ICommand newCommand)
        {
            this.theCommand = newCommand;
        }

        public void Press()
        {
            this.theCommand.Execute();
        }

        public void UndoPress()
        {
            this.theCommand.Undo();
        }
    }
}
