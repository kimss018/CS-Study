﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P106
    {
        static void Main1(string[] args)
        {
            // 코드 2-56
            long longNumber = 2147483647L + 2147483647L;
            int intNumber = (int)longNumber;

            Console.WriteLine(intNumber);
                                   
        }
    }
}
