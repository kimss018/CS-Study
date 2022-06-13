using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class _10__P181_185_
    {
        // 코드 4-26
        static void Main1(string[] args)
        {
            string input = "Potato Tomato";
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());
        }

        // 코드 4-27
        static void Main2(string[] args)
        {
            string input = "감자 고구마 토마토";
            string[] inputs = input.Split(new char[] { ' ' });

            foreach (var item in inputs)
            {
                Console.WriteLine(item );
            }
        }

        // 코드 4-28
        static void Main3(string[] args)
        {
            string input = "test       \n";
            Console.WriteLine("::" + input.Trim() + "::");
            Console.Read();
        }

        // 코드 4-29
        static void Main4(string[] args)
        {
            string[] array = { "감자", " 고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(",", array));


        }


    }
}
