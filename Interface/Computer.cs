using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Computer : IDisposable
    {
        List<IRAM> RAM = new List<IRAM>(4);
        List<ISSD> SSD = new List<ISSD>(2);
        ICPU CPU;
        

        public void AddDevice(IDevice device)
        {
            if (device is IRAM ramdevice)
            {
                RAM.Add(ramdevice);
            }
            else if (device is ISSD ssddevice)
            {
                SSD.Add(ssddevice);
            }
            else if (device is ICPU cpudevice)
            {
                CPU = cpudevice;
            }

        }
        public void RemoveDevice()
        {
            ICPU cpu = CPU;
            cpu.Unplug();

            foreach (IRAM ram in RAM)
            {
                ram.Eject();
            }

            foreach (ISSD ssd in SSD)
            {
                ssd.Remove();
            }
        }
        ~Computer()
        {
            RemoveDevice();
        }
        public void Dispose()
        {
            RemoveDevice();
        }
    }
}



