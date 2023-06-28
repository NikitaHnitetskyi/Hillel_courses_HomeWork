using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class SSD : ISSD
    {
        public int VolumeSSD {get;}

        public string Manufacturer { get; }

        public void Remove()
        {
            Console.WriteLine("Remove!");
        }
        public SSD(int volumessd, string manufacturer)
        {
            this.VolumeSSD = volumessd;
            this.Manufacturer = manufacturer;
        }
    }
}
