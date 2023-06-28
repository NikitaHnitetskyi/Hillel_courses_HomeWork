using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class RAM : IRAM
    {
        public int VolumeRAM { get; }

        public string Manufacturer { get; }

        public void Eject()
        {
            Console.WriteLine("Eject!");
        }
        public RAM(int volumeram,string manufacture)
        {
            this.VolumeRAM = volumeram;
            this.Manufacturer = manufacture;
        }
    }
}
