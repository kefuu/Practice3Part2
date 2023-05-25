using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3Part2
{
    public static class task1
    {
        public static int StringToInt(string str)
        {
            if (Int32.TryParse(str, out int number))
            {
                return number;
            }
            else
            {
                throw new OverflowException($"Рядок '{str}' не може бути перетворений в ціле число.");
            }
        }
    }
}
