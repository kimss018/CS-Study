using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class _01__P157_161_
    {
        static void Main1(string[] args)
        {
            // 코드 4-1
            Console.WriteLine("출력");
            Console.WriteLine("출력");
            Console.WriteLine("출력");
            Console.WriteLine("출력");
            Console.WriteLine("출력");

            // 코드 4-2
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("출력");
            }

            // 코드 4-3
            int[] intArray = { 52, 273, 32, 65, 103 };
            long[] longArray = { 52, 273, 32, 65, 103 };
            float[] floatArray = { 1.0F, 2.0F, 3.0F, 4.0F, 5.0F };
            double[] doubleArray = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            char[] charArray = { '가', '나', '다', '라' };
            string[] stringArray = { "윤인성", "연하진", "윤아린" };
        }

        static void Main2(string[] args)
        {
            // 코드 4-4
            int[] intArray = { 52, 273, 32, 65, 103 };

            intArray[0] = 0;

            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
        }

        static void Main3(string[] args)
        {
            // 코드 4-8
            int[] intArray = { 52, 273, 32, 65, 103 };

            Console.WriteLine(intArray.Length);
        }

        static void Main4(string[] args)
        {
            int[] intArray = new int[100];

            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[99]);
        }
    }
}
