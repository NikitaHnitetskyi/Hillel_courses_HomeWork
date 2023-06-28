using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class CPU : ICPU
    {
        public int NumberOfCores { get; }
        public string Manufacturer { get; }


        public void Unplug()
        {
            Console.WriteLine("Unplug!");
        }
        public CPU(int numberofcores, string manufacturer)
        {
            this.NumberOfCores = numberofcores;
            this.Manufacturer = manufacturer;
        }
    }
}
