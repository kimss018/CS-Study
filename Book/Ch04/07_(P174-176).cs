using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class _07__P174_176_
    {
        static void Main1(string[] args)
        {
            // 코드 4-20
            for ( int i = 0; i < 10; i++ )
            {
                for (int j = 0; j < i + 1; j++ )
                {
                    Console.Write('*');
                }
                Console.Write('\n');
            }


            // 코드 4-21
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10-a; b++)
                    Console.Write(' ');
                for (int b = 0; b < a + 1; b++)
                    Console.Write('*');
                Console.Write('\n');
            }
        }
    }
}
