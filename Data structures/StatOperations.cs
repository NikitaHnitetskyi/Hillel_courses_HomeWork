using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structdata
{
    public static class StatOperations
    {
        // числа которые ни разу не использовались сохраняем в пемеренную списка neverAppereared
        public static IEnumerable<int> NeverAppeared(List<int> results)
        {
            HashSet<int> unique = new HashSet<int>(results);
            for (int i = 1; i < 36; i++)
            {                                           //hashSet разобрать подробнее.
                if (!unique.Contains(i))
                {
                    yield return i;
                }
            }
        }

        //числа которые использовались чаще всего сохраняю в numbersCount
        public static List<int> MostAppeared(List<int> draw, int N)
        {
            Dictionary<int, int> numbersCount = new Dictionary<int, int>();

            foreach (var number in draw)
            {
                if (numbersCount.ContainsKey(number))
                {
                    numbersCount[number]++;
                }
                else
                {
                    numbersCount[number] = 1;
                }
            }
            //возврат: сортировка по убыванию извлекаем определенное число, выбираем и приводим к листу
            return numbersCount.OrderByDescending(x => x.Value).Take(N).Select(x => x.Key).ToList();
        }
    }
}

