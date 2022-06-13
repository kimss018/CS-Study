using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P107
    {
        static void Main1(string[] args)
        {
           
            // 코드 2-57
            var a = (int)10.0;
            var b = (float)10;
            var c = (double)10;

            // 코드 2-58
            long longNumber = 2147483647L + 2147483647L;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);          

        }
    }
}
