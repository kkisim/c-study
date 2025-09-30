using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Mymath
    {
        public static int Abs(int input)
        {
            if(input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }

        }
        public static double Abs(double input)
        {
            if (input < 0.0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }
    }
}
