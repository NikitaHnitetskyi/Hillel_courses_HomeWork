using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    public class Program
    {
        static object locker = new object();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(DoCount));
            Thread t2 = new Thread(new ThreadStart(DoCount));

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("Четных чисел: " + evenCount);
            Console.WriteLine("Нечетных чисел: " + oddCount);

            Console.ReadKey();
        }
        static int evenCount = 0;
        static int oddCount = 0;
        static void DoCount()
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int num = rnd.Next(0, 100);
                bool result = num % 2 == 0;
                lock (locker)
                {
                    if (result)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }
                }
            }
        }
    }
}

