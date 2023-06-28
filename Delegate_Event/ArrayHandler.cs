using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    internal class ArrayHandler
    {
        private int[] numbers;

        public ArrayHandler(int[] numbers)
        {
            this.numbers = numbers;
        }

        public event EventHandler<int> SquareRootIsInteger;

        public IEnumerable<double> SquareRoots(Func<int, bool> filter)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (filter(numbers[i]))
                {
                    double root = numbers[i].Sqrt();
                    if (root % 1 == 0)
                        SquareRootIsInteger?.Invoke(this, numbers[i]);
                    yield return root;
                }
            }
        }
    }
}

