using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
    public static class Extends
    {
        public static void @do(this bool condition, Action action)
        {
            if (condition)
            {
                action();
            }
        }

        public static void For(int len1, int len2, Action<int, int> action)
        {
            for (int i = 0; i < len1; i++)
            {
                for (int j = 0; j < len2; j++)
                {
                    action(i, j);
                }
            }
        }

    }
}
