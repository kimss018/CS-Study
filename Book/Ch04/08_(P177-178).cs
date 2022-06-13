using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class _08__P177_178_
    {


        // 코드 4-22
        static void Main1(string[] args)
        {
            while (true)
            {
                Console.Write("숫자를 입력해주세요(짝수를 입력하면 종료) : ");
                int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0)
                {
                    break;
                }    
            }
        }


        // 코드 4-23
        static void Main2(string[] args)
        {
            for(int i = 0; i <10; i++)
            {
                Console.WriteLine("외부 반복문");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("내부 반복문");
                    goto doNotUse;
                }
            }
         doNotUse:
            Console.WriteLine("goto 키워드");
        }
        
    }
}
