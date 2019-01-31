using MathHelper.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WNA.neural_network.neurons
{
    [Serializable]
    public class InputNeuron : AbstractNeuronWithWeight
    {
        public InputNeuron(int linkCount) : base(linkCount) {}

        public override double GetOutput(double input, IActivationFunction func)
        {
            return input;
        }
    }
}
