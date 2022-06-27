﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class P411
    {
        class PointClass
        {
            public int x;
            public int y;

            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        struct PointStruct
        {
            public int x;
            public int y;

            public PointStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main1(string[] args)
        {
            PointClass pointClassA = new PointClass(10, 20);
            PointClass pointClassB = pointClassA;

            pointClassB.x = 100;
            pointClassB.y = 200;

            Console.WriteLine("pointCalssA : " + pointClassA.x + ", " + pointClassA.y);
            Console.WriteLine("pointCalssB : " + pointClassB.x + ", " + pointClassB.y);
            Console.WriteLine();

            PointStruct pointStructA = new PointStruct(10, 20);
            PointStruct pointStructB = pointStructA;

            pointStructB.x = 100;
            pointStructB.y = 200;

            Console.WriteLine("pointStructA : " + pointStructA.x + "," + pointStructA.y);
            Console.WriteLine("pointStructB : " + pointStructB.x + "," + pointStructB.y);


        }
    }
}
