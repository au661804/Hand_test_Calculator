﻿using System;

namespace Hand_test_Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b; 
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }
    }
}