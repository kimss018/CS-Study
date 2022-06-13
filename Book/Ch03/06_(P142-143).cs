using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class _06__P142_143_
    {
        static void Main1(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            
            // 코드 3-13
            Console.WriteLine(number % 2 == 0 ? true : false);
            Console.WriteLine(number % 2 == 0 ? "짝수 " : "홀수");




            // 코드 3-14
            Console.WriteLine(number > 0 ? "자연수입니다" : "자연수가 아닙니다.");
            
        }
    }
}
