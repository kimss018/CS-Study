﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Book.Ch04
{
    internal class _10__P186_
    {
        // 코드 4-30
        static void Main1(string[] args)
        {

           
            Console.Write("메서드 호출 전");
            Console.SetCursorPosition(5, 5);
            Console.Write("메서드 호출 후");
        }


        // 코드 4-31
        class Program
        {
            static void Main2(string[] args)
            {
                Console.WriteLine("첫 번째 출력");
                Thread.Sleep(1000);
                Console.WriteLine("두 번째 출력");
                Thread.Sleep(1000);
                Console.WriteLine("세 번째 출력");
            }
        }
                
    }
}
