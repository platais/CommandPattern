using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class DeviceButton
    {
        private ICommand _command;
        public DeviceButton(ICommand command)
        {
            _command = command;
        }

        public void Press() 
        {
            _command.Execute();
        }

        public void Unpress()
        {
            _command.Unexecute();
        }
    }
}
