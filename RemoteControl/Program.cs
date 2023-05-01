using RemoteControl.Interfaces;
using RemoteControl.Commands;
using RemoteControl.Recivers;
using RemoteControl.Invokers;
using RemoteControl.Clients;

namespace RemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice tvRemote = TVRemot.GetDevice();
            TurnDeviceOn onCommand = new TurnDeviceOn(tvRemote);
            DeviceButton btn = new DeviceButton(onCommand);
            btn.Press();

            TurnDeviceOff offCommand = new TurnDeviceOff(tvRemote);
            btn = new DeviceButton(offCommand);
            btn.Press();

            TurnVolumUp volUpCommand = new TurnVolumUp(tvRemote);
            btn = new DeviceButton(volUpCommand);
            btn.Press();
            btn.Press();
            btn.Press();
            btn.Press();
            btn.Press();

            TurnDeviceDown volDownCommand = new TurnDeviceDown(tvRemote);
            btn = new DeviceButton(volDownCommand);
            btn.Press();
            btn.Press();
            btn.Press();
            btn.Press();
            btn.Press();
            btn.Press();
            btn.Press();

            IElectronicDevice radioRemote = RadioRemote.GetDevice();
            TurnDeviceOn radioOnCommand = new TurnDeviceOn(radioRemote);
            DeviceButton radioButton = new DeviceButton(radioOnCommand);
            radioButton.Press();

            List<IElectronicDevice> allDevices = new List<IElectronicDevice>();
            allDevices.Add(radioRemote);
            allDevices.Add(tvRemote);
            TurnAllOff turnAllOff = new TurnAllOff(allDevices);
            DeviceButton button = new DeviceButton(turnAllOff);
            button.Press();

            Console.WriteLine("Undo");



        }
    }
}
