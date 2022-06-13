using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class _05__P170_
    {
        // 코드 4-16
        static void Main1(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, };

            for (int i = intArray.Length -1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }
        }
    }
}
