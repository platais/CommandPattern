using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class TurnOffAllDevices : ICommand
    {
        private List<IDevice> _devices;
        public TurnOffAllDevices(List<IDevice> devices)
        {
            _devices = devices;
        }
        public void Execute() 
        {
            foreach (var device in _devices) 
            {
                device.Off();
            }
        }

        public void Unexecute()
        {
            foreach (var device in _devices)
            {
                device.On();
            }
        }
    }
}
