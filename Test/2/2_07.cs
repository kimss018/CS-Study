﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2
{
    internal class _2_07
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("1과 5의 최대공약수 : " + Gcd(1, 5));
            Console.WriteLine("1과 5의 최대공약수 : " + Gcd(3, 6));
            Console.WriteLine("1과 5의 최대공약수 : " + Gcd(12, 18));
            Console.WriteLine("1과 5의 최대공약수 : " + Gcd(60, 24));
            Console.WriteLine("1과 5의 최대공약수 : " + Gcd(192, 162));

        }

        public static int Gcd(int a, int b)
        {
            int temp;

            if (a < b)
                temp = a;
            else
                temp = b;
            while (true)
            {
                if (a % temp == 0 && b % temp == 0)
                {
                    break;
                  
                }
                temp--;
            }
            return temp;

        }
    }
}
