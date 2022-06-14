using Book.Ch07.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    
    internal class P336
    {
        class Dog : Animal
        {
            public string Color { get; set; }

            public void Bark()
            {
                Console.WriteLine("왈왈 짓습니다.");
            }
        }

        class Cat : Animal
        {
            public void Meou()
            {
                Console.WriteLine("냥냥 웁니다.");
            }
        }
    }
    
    

    
}
