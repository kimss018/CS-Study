﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P271
    {
        class Test
        {
            public int Multiply(int min, int max)
            {
                int output = 1;
                for (int i = min; i <= max; i++)
                {
                    output *= i;    
                }
                return output;
            }
        }

        static void Main1(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Multiply(1,10));
        }
    }
}
