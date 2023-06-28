using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structdata
{
    public static class Lottery
    {
        //получает число(100), сохраняет в список result и возвращает (от 0 до 100) 
        public static List<int> Emit(int number)
        {
            Random random = new Random();
            List<int> result = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                result.Add(random.Next(1,36));
            }
            return result;
        }
    }
}

