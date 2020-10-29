using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public interface IDevice
    {
        public void On();
        public void Off();
        public void VolUp();
        public void VolDown();
    }
}
