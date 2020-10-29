using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class TurnRadioVolUp : ICommand
    {
        private IDevice _radio;
        public TurnRadioVolUp(IDevice radio)
        {
            _radio = radio;
        }
        public void Execute()
        {
            _radio.VolUp();
        }

        public void Unexecute()
        {
            _radio.VolDown();
        }
    }
}
