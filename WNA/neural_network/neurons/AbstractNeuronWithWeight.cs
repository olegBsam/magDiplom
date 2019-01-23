using MathHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MathHelper.MathHelper;

namespace WNA.neural_network.neurons
{
    [Serializable]
    public abstract class AbstractNeuronWithWeight : AbstractNeuron
    {
        public double[] Weights
        {
            get;
            protected set;
        }
        public double[] LastWeightCorrect
        {
            get;
            set;
        }

        protected AbstractNeuronWithWeight(int linkCount) : base()
        {
            Weights = new double[linkCount];
            LastWeightCorrect = new double[linkCount];
            for (int i = 0; i < linkCount; i++)
            {
                Weights[i] = RandomHelper.GetDouble();
                LastWeightCorrect[i] = 0;

                if (R <= 0)
                {
                    throw new Exception("Радиус <= 0");
                }               
            }
        }

        internal double GetSumError(double[] errorOnOutput)
        {
            double error = 0;
            for (int i = 0; i < Weights.Length; i++)
            {
                error += errorOnOutput[i] * Weights[i];
            }
            return error;
        }

    }
}
