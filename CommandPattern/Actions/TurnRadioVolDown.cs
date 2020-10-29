using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class TurnRadioVolDown: ICommand
    {
        private IDevice _radio;
        public TurnRadioVolDown(IDevice radio)
        {
            _radio = radio;
        }
        public void Execute()
        {
            _radio.VolDown();
        }

        public void Unexecute()
        {
            _radio.VolUp();
        }
    }
}
