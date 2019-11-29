using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public  class CalculatorEngine
    {
        public virtual int Addition(int a,int b)
        {
            return a+b;
        }
       public virtual int Substraction(int a, int b)
        {
            return a-b;
        }
       public virtual int Multiplication(int a, int b)
        {
            return a * b;
        }
        public virtual int Division(int val1, int val2)
        {
            int res;
            if (val2 != 0)
            {
                res = val1 / val2;
            }
            else
            {
                res = Int32.MinValue;
            }
            return res;
        }
        public virtual double SquareRoot(double a)
        {
            return  Math.Sqrt (a);
        }
        public virtual double Square(double a)
        {
            return Math.Pow(a, 2);
        }
        public virtual double percentage(double a)
        {
            return a/100;
        }
    }
}
