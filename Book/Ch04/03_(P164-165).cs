using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class _03__P164_165_
    {
        
        // 코드 4-11
        static void Main1(string[] args)
        {
            string input;
            do
            {
                Console.Write("입력(exit를 입력하면 종료):");
                input = Console.ReadLine();
            }
            while (input != "exit");
        }
    }
}
