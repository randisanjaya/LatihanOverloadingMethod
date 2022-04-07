using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            return Math.Min(number1, number2);
        }

        public double FindMinimum(int number1, int number2, float number3)
        {
            return Math.Min(number1, number2);

        }

        public int FindMaximum(int number1, int number2)
        {
            return Math.Max(number1, number2);
        }

        public double FindMaximum(int number1, int number2, float number3)
        {
            return Math.Max(number1, number3);
        }
    }
}
