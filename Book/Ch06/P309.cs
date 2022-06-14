﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P309
    {

        class Fibonacci
        {
            private static Dictionary<int, long> memo = new Dictionary<int, long>();
            public static long Get(int i)
            {
                if (i < 0) { return 0; }
                if (i == 1) { return 1; }

                if (memo.ContainsKey(i))
                {
                    return memo[i];
                }
                else
                {
                    long value = Get (i -2 ) + Get(i - 1);
                    memo[i] = value;
                    return value;
                }
            }
           
        }

        class Program
        {
            static void Main1(string[] args)
            {
                Console.WriteLine(Fibonacci.Get(40));
                Console.WriteLine(Fibonacci.Get(100));
            }
        }
    }
}
