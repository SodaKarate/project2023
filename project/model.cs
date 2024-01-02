using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class model
    {
        public double sin(double x)
        {

            return Math.Sin(Math.PI / 180 * x);
        }
        public double cos(double x)
        {

            return Math.Cos(Math.PI / 180 * x);
        }
        public double tan(double x)
        {

            return Math.Tan(Math.PI / 180 * x);
        }
        public double fact(double x)
        {
            for (double i = x-1; i > 0; i--)
            {
                x *= i;
            }             
            return x;
        }
        public double mult(string input)
        {
            double num1 = double.Parse(input.Split("*")[0]);
            double num2 = double.Parse(input.Split("*")[1]);
            return num1 * num2;
        }
        public double pow(string input)
        {
            double num1 = double.Parse(input.Split("^")[0]);
            double num2 = double.Parse(input.Split("^")[1]);
            return Math.Pow(num1,num2);
        }
        public double div(string input)
        {
            double num1 = double.Parse(input.Split("/")[0]);
            double num2 = double.Parse(input.Split("/")[1]);
            return num1/num2;
        }
        public double sq(double x)
        {
            return Math.Pow(x,2);
        }
        public double add(string input)
        {
            double num1 = double.Parse(input.Split("+")[0]);
            double num2 = double.Parse(input.Split("+")[1]);
            return num1 + num2;
        }
        public double sqr(double x)
        {
            return Math.Sqrt(x);
        }
        public double sub(string input)
        {
            double num1 = double.Parse(input.Split("-")[0]);
            double num2 = double.Parse(input.Split("-")[1]);
            return num1 - num2;
        }
        public bool hunloc()
        {
            CultureInfo ci = CultureInfo.InstalledUICulture;
            if (ci.Name == "hu-HU")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
