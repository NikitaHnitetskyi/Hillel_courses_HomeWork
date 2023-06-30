using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample
{
    internal class Engine : IEngine
    {
        public void Ignite()
        {
            Console.WriteLine("Wrrooom-wroom!");
        }
    }
}
