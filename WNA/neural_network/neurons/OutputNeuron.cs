﻿using MathHelper.Function;
using System;

namespace WNA.neural_network.neurons
{
    [Serializable]
    public class OutputNeuron : AbstractNeuron
    {
        public OutputNeuron() : base(){}

        public override double GetOutput(double x, IActivationFunction func)
        {
            return func.Function(x);
        }

        public override double GetDerivative(double x, IActivationFunction func)
        {
            return func.DerivativeOnX(x);
        }
    }
}