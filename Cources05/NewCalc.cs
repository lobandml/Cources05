﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources05
{
    public static class NewCalc
    {
        public static double Plus(double a, double b)
        { 
            return a + b; 
        }
        public static double Minus(double a, double b)
        {
            return a - b;
        }
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                return Double.NaN;
            }
            else
            {
                return a / b;
            }
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }
        public static double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }

    }
}
