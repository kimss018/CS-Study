using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    class Wanted<T>
    {
        public T Value;
        public Wanted(T value)
        {
            Value = value;
        }
    }

    internal class P396
    {
        static void Main(string[] args)
        {
            Wanted<string> wantedString = new Wanted<string>("String");
            Wanted<int> wantedint = new Wanted<int>(52273);
            Wanted<double> wanteddouble = new Wanted<double>(52.273);


        }
        
    }
}
