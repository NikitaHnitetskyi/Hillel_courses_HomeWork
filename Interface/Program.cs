using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Computer computer2 = new Computer();

            computer2.AddDevice(new CPU(9, "Intel"));
            computer2.AddDevice(new RAM(32, "Samsung"));
            computer2.AddDevice(new SSD(512, "M2"));


            using (Computer computer1 = new Computer())
            {
                computer1.AddDevice(new CPU(5, "Ryzen"));
                computer1.AddDevice(new RAM(16, "Kingston"));
                computer1.AddDevice(new SSD(256, "M2"));
            }

            Console.ReadKey();
        }
    }
}