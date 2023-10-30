using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    internal class Tabul
    {
        public double[,] xy = new double[1000, 2];
        public int n = 0;

        double f1(double x) 
        {
            return Math.Pow((3 * x - 1), 2) / Math.Pow(x, 5);
        }
        double f2(double x) 
        {
            return Math.Log(Math.Sqrt(Math.Abs(x + 5)));
        }
        double f3(double x) 
        {
            return Math.Cos(Math.Sqrt(1 + Math.Pow(x, 2)));
        }
        public void tab (double xn = -2.46, double xk = 28.8, double h = 0.6, double a = 1.4 )
        {
            double x = xn, y;
            int i = 0;
            while ( x <= xk ) 
            {
                if ( x < 0) 
                {
                    y = f1(x);
                }
                else
                {
                    if ((x >= 0) && (x < a))
                    {
                        y = f2(x);
                    }
                    else
                        y = f3(x);
                }
                xy[i, 0] = x;
                xy[i, 1] = y;
                x = x + h;
                i++;
            }
            n = i;
        }
    }
}
