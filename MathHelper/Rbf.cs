using MathHelper.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper.Function.Rbf
{
    public class GaussFunc : IFunction
    {
        public double Function(double x, double c, double r)
        {
            return Math.Exp(-Math.Pow(x - c, 2) / (2.0 * Math.Pow(r, 2)));
        }

        public double DerivativeOnX(double x, double c, double r)
        {
            double func = Function(x, c, r);
            return -func * (x - c) / Math.Pow(r, 2);
        }

        public double DerivativeOnC(double x, double c = 0, double r = 0)
        {
            throw new NotImplementedException();
        }

        public double DerivativeOnR(double x, double c = 0, double r = 0)
        {
            throw new NotImplementedException();
        }
    }

    public class MultiquadricFunc : IFunction
    {
        public double Function(double x, double c, double r)
        {
            return Math.Sqrt(1.0 + Math.Pow(x - c, 2) / (r));
        }

        public double DerivativeOnX(double x, double c, double r)
        {
            return 1.0 / (Function(x,c,r)) * (x - c) / r;
        }

        public double DerivativeOnC(double x, double c = 0, double r = 0)
        {
            throw new NotImplementedException();
        }

        public double DerivativeOnR(double x, double c = 0, double r = 0)
        {
            throw new NotImplementedException();
        }
    }

    public class InverseQuadraticFunc : IFunction
    {
        public double Function(double x, double c, double r)
        {
            return 1.0 / (1.0 + Math.Pow(x - c, 2) / (r));
        }

        public double DerivativeOnX(double x, double c, double r)
        {
            return -Math.Pow(Function(x, c, r), 2) * ((2 * (x - c)) / (r));
        }

        public double DerivativeOnC(double x, double c = 0, double r = 0)
        {
            throw new NotImplementedException();
        }

        public double DerivativeOnR(double x, double c = 0, double r = 0)
        {
            throw new NotImplementedException();
        }
    }

    public class InverseMultiquadricFunc : IFunction
    {
        public double Function(double x, double c, double r)
        {
            return 1.0 / Math.Sqrt(1.0 + Math.Pow(x - c, 2.0) / (r));
        }

        public double DerivativeOnX(double x, double c, double r)
        {
            return (-2.0 * Math.Pow(Function(x, c, r), 1.5)) * ((2.0 * (x - c)) / r);
        }

        public double DerivativeOnC(double x, double c = 0, double r = 0)
        {
            throw new NotImplementedException();
        }

        public double DerivativeOnR(double x, double c = 0, double r = 0)
        {
            throw new NotImplementedException();
        }
    }

    public class TricubeFunc : IFunction
    {
        public double Function(double x, double c, double r)
        {
            return (70.0 / 81.0) * Math.Pow(1.0 - Math.Pow(Math.Abs(x), 3), 3);
        }

        public double DerivativeOnX(double x, double c, double r)
        {
            throw new NotImplementedException();
        }

        public double DerivativeOnC(double x, double c = 0, double r = 0)
        {
            throw new NotImplementedException();
        }

        public double DerivativeOnR(double x, double c = 0, double r = 0)
        {
            throw new NotImplementedException();
        }
    }
}
