using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegate_Event;

namespace ClassesForDataBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 10, 25, 30, 50 };
            ArrayHandler handler = new ArrayHandler(numbers);
            handler.SquareRootIsInteger += OnSquareRootIsInteger;




            Func<int, bool> filter = num => num > 5;

            var roots = handler.SquareRoots(filter).ToArray();

            Console.WriteLine("Результат:");
            
            for (int i = 0; i < roots.Length; i++)
            {
                Console.WriteLine($"Корень из {numbers[i]} = {roots[i]}");
            }

            Console.ReadKey();
        }

        private static void OnSquareRootIsInteger(object sender, int integerRoot)
        {
            Console.WriteLine($"Корень числа {integerRoot} - целое число");
        }
    }
}