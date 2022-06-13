using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P108
    {
        static void Main1(string[] args)
        {
           
            // 코드 2-59
            long longNumber = 52273;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);
           

            // 코드 2-60
            long longNumbers = 2147483647L +2147483647L;
            int longToInt = (int)longNumbers;
            Console.WriteLine(longToInt);

            double doubleNumber = 52.27310332; 
            int doubleToInt = (int)doubleNumber;
            Console.WriteLine(doubleToInt);
        }
    }
}
