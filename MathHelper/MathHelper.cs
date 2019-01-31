using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
    public static class RandomHelper
    {
        private static Random rand = new Random();
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
}