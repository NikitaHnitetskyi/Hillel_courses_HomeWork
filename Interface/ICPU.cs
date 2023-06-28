using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface ICPU : IDevice
    {
        public int NumberOfCores { get; }
        void Unplug();
    }
}
