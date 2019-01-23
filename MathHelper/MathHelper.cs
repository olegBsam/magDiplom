using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
    public static class MathHelper
    {
        private static Random rand = new Random();
        public static class RandomHelper
        {
            public static double GetDouble()
            {
               return rand.Next(100) / 100.0;
            }

            public static double GetDouble(double offset)
            {
                double value = rand.Next(100) / 100.0;
                return value == 0 ? value + offset : value;
            }
        }

        public static class GaussFunction
        {
            public static double Function(double x, double c, double r)
            {
                return Math.Exp(-Math.Pow(x - c, 2) / (2 * Math.Pow(r, 2)));
            }

            public static double DerivativeOnX(double x, double c, double r)
            {
                double func = Function(x, c, r);
                return -func * (x - c) / Math.Pow(r, 2);
            }
        }

        public static class SigmoidFunction
        {
            public static double Function(double x)
            {
                return 1.0 / (1.0 + Math.Exp(-x));
            }

            public static double DerivativeOnX(double x)
            {
                double res = Function(x);
                return res * (1 - res);
            }
        }

        public static class OffsetSigmoidFunction
        {
            public static double Function(double x)
            {
                return (2.0 / (1.0 + Math.Exp(-x))) - 1.0;
            }

            public static double DerivativeOnX(double x)
            {
                double func = Function(x);
                return 0.5 * (1 + func) * (1 - func);
            }
        }

    }
}
