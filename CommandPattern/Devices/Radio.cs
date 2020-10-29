using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class Radio : IDevice
    {
        private int _vol = 0;
        public void Off()
        {
            Console.WriteLine("Radio is OFF");
        }

        public void On()
        {
            Console.WriteLine("Radio is ON");
        }

        public void VolDown()
        {//testinu,lai atgriez nulli, nevis iet miinusaa
            _vol--;
            Console.WriteLine($"Radio volume {_vol}");
        }

        public void VolUp()
        {
            _vol++;
            Console.WriteLine($"Radio volume {_vol}");
        }
    }
}
