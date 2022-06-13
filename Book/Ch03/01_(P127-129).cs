using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class _01__P127_129_
    {
        static void Main1(string[] args)
        {
            
            //코드 3-1
            Console.Write("숫자 입력 : ");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("짝수입니다!");
            }    
            if (input % 2 == 1)
            {
                Console.WriteLine("홀수입니다!");
            }

            // 코드 3-3
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);


            // 코드 3-4
            if(DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }
            if(12 <= DateTime.Now.Hour)
            {
                Console.WriteLine("오후입니다.");
            }    
        }
    }
}
