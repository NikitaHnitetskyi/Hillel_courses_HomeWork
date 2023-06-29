using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_16
{
    public class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public Country Country { get; set; }
        public int CreationDate { get; set; }
        public bool IsCapital { get; set; }

    }
}
