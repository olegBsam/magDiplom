using System;
using static MathHelper.MathHelper;

namespace WNA.neural_network.neurons
{
    [Serializable]
    public class OutputNeuron : AbstractNeuron
    {
        public OutputNeuron() : base(){}

        public override double GetOutput(double x)
        {
            return SigmoidFunction.Function(x);
        }

        public override double GetDerivative(double x)
        {
            return SigmoidFunction.DerivativeOnX(x);
        }
    }
}