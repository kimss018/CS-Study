using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class _03__P132_133_
    {
        static void Main1(string[] args)
        {
            // 코드 3-7
            if(DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }
            else
            {
                if(DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심 먹을 시간 입니다.");
                }
                else
                {
                    Console.WriteLine("저녁 먹을 시간 입니다.");
                }
            }
        }
    }
}
