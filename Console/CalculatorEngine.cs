using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class CalculatorEngine
    {
        public int add(int a,int b)
        {
            return a+b;
        }
       public int sub(int a, int b)
        {
            return a-b;
        }
       public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Div(int val1, int val2)
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
    }
}
