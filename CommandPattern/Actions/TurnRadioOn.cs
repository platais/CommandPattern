using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class TurnRadioOn : ICommand
    {
        private IDevice _radio;
        public TurnRadioOn(IDevice radio)
        {
            _radio = radio;
        }

        public void Execute()
        {
            _radio.On();
        }

        public void Unexecute()
        {
            _radio.Off();
        }
    }
}
