using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IRAM : IDevice
    {
        public int VolumeRAM { get; }
        void Eject();
    }
}
