using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class _02__P162_163_
    {
        
        // 코드 4-9
        static void Main1(string[] args)
        {
            while (true)
            {
                Console.WriteLine("무한 반복");
            }
        }
        // 코드 4-10
        static void Main2(string[] args)
        {
            int i = 0;
            int[] intArray = { 52, 273, 32, 65, 103 };

            while (i < intArray.Length)
            {
                Console.WriteLine(i + "번째 출력 : " + intArray[i]);

                i++;
            }
        }

    }
}
