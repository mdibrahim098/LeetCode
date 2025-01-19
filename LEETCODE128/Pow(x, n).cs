using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    class Pow_x__n_
    {
        public double MyPow(double x, int n)
        {
            double result = 1;
            if (n == 0)
            {
                return result + 0;
            }
            if (x == 0)
            {
                return result * 0;
            }
            // n positive 
            if (n > 0)
            {
                if (x > 0)
                {
                    result = x;
                    for (int i = 1; i <= n; i++)
                    {
                        result = result * n;
                    }
                }
                if (x < 0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        result = result * n;
                    }
                }
            }

            // n negative 
            if (n < 0)
            {
                if (x > 0)
                {
                    result = x;
                    for (int i = 1; i <= n; i++)
                    {
                        result = result * n;
                    }
                }
                if (x < 0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        result = result * n;
                    }
                }
            }
            // n even
            if (n > 0)
            {
                if (n % 2 != 0)
                {
                    return result * -1;
                }
                else
                {
                    return result;
                }
            }
            // n odd
            if (n < 0)
            {

                if (n % 2 != 0)
                {
                    return 1 / (result * -1);
                }
                else
                {
                    return 1 / (result);
                }
            }

            return result;

        }


        static void Main(string[] args)
        {
            Pow_x__n_ obj = new Pow_x__n_();
            double x = 2.00000;
            int n = 10;
            Console.WriteLine(obj.MyPow(x,n));
            Console.ReadLine();

        }

    }
}
