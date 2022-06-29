﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Final02
{
    internal class _2_02
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("키(cm) 입력 : ");
            double height = double.Parse(Console.ReadLine());
            height /= 100;

            Console.Write("체중(kg) 입력 : ");
            double weight = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);

            string result;
            if (bmi < 20)
                result = "저체중";
            else if (bmi < 25)
                result = "정상체중";
            else if (bmi < 30)
                result = "경도비만";
            else
                result = "고도비만";

            Console.WriteLine("BMI = {0:F1}, '{1}'입니다.", bmi, result);
        }
    }
}
