using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.final03
{
    internal class _3_07
    {
        static void Main1(string[] args)
        {
            DrawPyramid(3);
            DrawPyramid(5);
            DrawPyramid(7);
        }

        public static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n+1; j++)
                    Console.Write(" ");

                for (int k = i; k < 2 * i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
