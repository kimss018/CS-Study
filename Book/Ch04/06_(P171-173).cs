using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class _06__P171_173_
    {
        static void Main1(string[] args)
        {
            // 코드 4-17
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };

            foreach (string item in array)
            {
                Console.WriteLine(item);
            }



            // 코드 4-18
            string[] array2 = { "사과", "배", "포도", "딸기", "바나나" };

            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
