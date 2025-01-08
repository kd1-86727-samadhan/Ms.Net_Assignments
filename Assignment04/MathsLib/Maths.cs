﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLib
{
    public class Maths
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y) { return x - y; }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            if(y == 0)
                throw new DivideByZeroException("Cannot divide by zero");
            return x / y;
        }


    }
}
