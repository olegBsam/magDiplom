using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathHelper.Function;

namespace WNA.neural_network.neurons
{
    [Serializable]
    public abstract class AbstractNeuron
    {
        private static Random rand = new Random();
        public AbstractNeuron()
        {
            R = rand.Next(100) / 100.0 + 0.1;
            C = rand.Next(100) / 100.0 - 0.5;
        }

        public double C
        {
            get;
            set;
        }
        public double R
        {
            get;
            set;
        }

        public virtual double GetOutput(double x, IFunction func)
        {
            return func.Function(x, C, R);
        }

        public virtual double GetDerivative(double x, IFunction func)
        {
            return func.DerivativeOnX(x, C, R);
        }
    }
}
