using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper.Function.NotRbf
{
    [ActivationFunction("SigmoidFunc", "Сигмоидальная")]
    public class SigmoidFunc : IActivationFunction
    {
        public double Function(double x, double c = 0, double r = 0)
        {
            return 1.0 / (1.0 + Math.Exp(-x));
        }

        public double DerivativeOnX(double x, double c = 0, double r = 0)
        {
            double res = Function(x);
            return res * (1.0 - res);
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


    [ActivationFunction("OffsetSigmoidFunc", "Смещенная сигмоидальная")]
    public class OffsetSigmoidFunc : IActivationFunction
    {
        public double Function(double x, double c = 0, double r = 0)
        {
            return (2.0 / (1.0 + Math.Exp(-x))) - 1.0;
        }

        public double DerivativeOnX(double x, double c = 0, double r = 0)
        {
            double func = Function(x);
            return 0.5 * (1.0 + func) * (1.0 - func);
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
