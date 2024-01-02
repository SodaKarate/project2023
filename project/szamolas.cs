using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class szamolas
    {
        public float Add(float num1, float num2)
        {
            return num1 + num2;
        }
        public float subtract(float num1, float num2)
        {
            return num1 - num2;
        }
        public float multiply(float num1, float num2)
        {
            return num1 * num2;
        }
        public float divide(float num1, float num2)
        {
            //itt majd meg kell nezni hogy a szam az ne legyen 0 ennek a futtatasa elott
            return num1 / num2;
        }
        public int factorial(int num)
        {
            //itt majd meg kell nezni hogy a szam az ne legyen 0 ennek a futtatasa elott
            int c = 1;
            for (int i = num; i > 0; i--)
                c *= i;
            return c;
        }
        public double sin(float num)
        {
            //itt meg kell nezni hogy a szam az -1 es 1 kozt van
            return Math.Sin(num);
        }
        public double cos(float num)
        {
            //itt meg kell nezni hogy a szam az -1 es 1 kozt van
            return Math.Cos(num);
        }
        public double tan(float num)
        {
            return Math.Tan(num);
        }
    }
}
