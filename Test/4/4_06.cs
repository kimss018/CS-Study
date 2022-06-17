using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._4
{
   class MyIndexer<T>
    {
        private T[] array = new T[10];

        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
    }

    internal class _4_06
    {
        static void Main1(string[] args)
        {
            var myIdexer = new MyIndexer<string>();

            myIdexer[0] = "Hello, World!";
            myIdexer[1] = "Hello, Korea!";
            myIdexer[2] = "Hello, Busan!";
            myIdexer[3] = "Hello, C#!";

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(myIdexer[i]);
            }
            
        }
    }
}
