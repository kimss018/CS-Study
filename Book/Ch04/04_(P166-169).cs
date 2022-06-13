using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class _04__P166_169_
    {
        // 코드 4-12
        static void Main1(string[] args)
        {
            int output = 0;

            for (int i = 0; i <= 100; i++)
            {
                output += i;
            }

            Console.WriteLine(output);
        }

        // 코드 4-13
        static void Main2(string[] args)
        {
            int output = 1;

            for (int i = 1; i <= 20; i++)
            {
                output *= i;
            }

            Console.WriteLine(output);
        }

        static void Main3(string[] args)
        {
            //코드 4-14
            for (int i = '가'; i <= '힣'; i++)
            {
                Console.Write((char)i);
            }

            // 코드 4-15
            long start = DateTime.Now.Ticks;
            long count = 0;

            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }

            Console.WriteLine(count + "만큼 반복했습니다.");
        }
    }
}
