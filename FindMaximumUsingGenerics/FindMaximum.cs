﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumUsingGenerics
{
    internal class FindMaximum
    {
        public static double FindDoubleMaximum(double num1,double num2, double num3)
        {
            if (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) >= 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) >= 0)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }

    }
}
