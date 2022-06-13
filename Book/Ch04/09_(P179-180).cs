using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class _09__P179_180_
    {
        // 코드 4-24
        static void Main1(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        // 코드 4-25
        static void Main2(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                if(i % 2 != 0 )
                {
                    Console.WriteLine(i);
                }
            }
        }


    }
}
