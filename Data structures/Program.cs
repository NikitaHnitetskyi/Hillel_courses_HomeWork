using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structdata
{
    public static class Program
    {
        static void Main(string[] args)
        {
            // Создаем список результатов 10, 50 и 100 розыгрышей
            List<List<int>> draws = new List<List<int>>();
           
            draws.Add(Lottery.Emit(10));
            draws.Add(Lottery.Emit(50));
            draws.Add(Lottery.Emit(100));

            // Получаем набор чисел, которые никогда не появлялись
            foreach (var draw in draws)
            {
                var neverAppeared = StatOperations.NeverAppeared(draw);
                Console.WriteLine($"Числа, которые никогда не выпадали в {draw.Count} розыгрышах:");
                Console.WriteLine(string.Join(", ", neverAppeared));
                Console.WriteLine();
            }

            // Получаем топ 10 чисел по частоте их появления
            int N = 10;
            foreach (var draw in draws)
            {
                List<int> mostAppeared = StatOperations.MostAppeared(draw, N);
                Console.WriteLine($"Топ {N} чисел по частоте их появления в {draw.Count} розыгрышах:");
                Console.WriteLine(string.Join(", ", mostAppeared));
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}