using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Remote
    {
        public static IDevice GetDevice() 
        {
            return new Radio();
        }

    }
}
