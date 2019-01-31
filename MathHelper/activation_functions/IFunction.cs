using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper.Function
{
    public interface IActivationFunction
    {
        double Function(double x, double c = 0, double r = 0);
        double DerivativeOnX(double x, double c = 0, double r = 0);
        double DerivativeOnC(double x, double c = 0, double r = 0);
        double DerivativeOnR(double x, double c = 0, double r = 0);
    }
}