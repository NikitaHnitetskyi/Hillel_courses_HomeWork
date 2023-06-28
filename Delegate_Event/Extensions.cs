using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    public static class Extensions
    {
        public static double Sqrt(this int number)
        {
            return Math.Sqrt(number);
        }
    }
}
