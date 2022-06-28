using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class P446
    {
        static void Main1(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\1302\Desktop\test.txt"))
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}
