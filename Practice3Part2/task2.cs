using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3Part2
{
    public static class task2
    {
        public static int BinaryStringToInt(string binaryStr)
        {
            foreach (char c in binaryStr)
            {
                if (c != '0' && c != '1')
                {
                    throw new FormatException($"Рядок '{binaryStr}' не є дійсним двійковим числом.");
                }
            }

            try
            {
                return Convert.ToInt32(binaryStr, 2);
            }
            catch (OverflowException)
            {
                throw new OverflowException($"Двійкове число '{binaryStr}' занадто велике, щоб вмістити його в тип int.");
            }
        }
    }
}