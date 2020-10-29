using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class TV: IDevice
    {
            private int _vol = 0;
            public void Off()
            {
                Console.WriteLine("Tv is OFF");
            }

            public void On()
            {
                Console.WriteLine("Tv is ON");
            }

            public void VolDown()
            {//testinu,lai atgriez nulli, nevis iet miinusaa
                _vol--;
                Console.WriteLine($"Tv volume {_vol}");
            }

            public void VolUp()
            {
                _vol++;
                Console.WriteLine($"Tv volume {_vol}");
            }
        
    }
}
