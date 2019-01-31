using MathHelper.Function;
using System;
using System.Collections.Generic;
using WNA.neural_network.layers;

namespace WNA.neural_network
{
    [Serializable]
    public class NeuroNet
    {
        InputLayer inputLayer;
        HiddenLayer hiddenLayer;
        OutputLayer outputLayer;

        public int InputLayerSize
        {
            get;
            private set;
        }
        public int HiddenLayerSize
        {
            get;
            private set;
        }
        public int OutputLayerSize
        {
            get;
            private set;
        }

        public double[] InputLayerOutput { get; private set; }
        public double[] HiddenLayerOutput { get; private set; }
        public double[] OutputLayerOutput { get; private set; }


        public double[] HiddenLayerInput { get; private set; }
        public double[] OutputLayerInput { get; private set; }


        public NeuroNet(int inputLayerSize, int hiddenLayerSize, int outputLayerSize, IActivationFunction rbFunc, IActivationFunction notRbFunc)
        {
            InputLayerSize = inputLayerSize;
            OutputLayerSize = outputLayerSize;
            HiddenLayerSize = hiddenLayerSize;

            inputLayer = new InputLayer(inputLayerSize, hiddenLayerSize);
            hiddenLayer = new HiddenLayer(hiddenLayerSize, outputLayerSize, rbFunc);
            outputLayer = new OutputLayer(outputLayerSize, notRbFunc);
        }

        public double[] CalculateOutputs(double[] inputs)
        {
            double[] result, layerOutputs;

            HiddenLayerInput = inputLayer.GetOutputVector(inputs, out layerOutputs);//вход скрытого с весами
            InputLayerOutput = layerOutputs;//выход входного

            OutputLayerInput = hiddenLayer.GetOutputVector(HiddenLayerInput, out layerOutputs);
            HiddenLayerOutput = layerOutputs;

            result = outputLayer.GetOutputVector(OutputLayerInput, out layerOutputs);
            OutputLayerOutput = layerOutputs;

            return result;
        }

        internal IEnumerable<double> TrainOutputLayer(double[] outputVector, double[] learnOutput, double[] layerInput)
        {
            return outputLayer.Train(outputVector, learnOutput, layerInput);
        }

        internal double[] TrainHiddenLayer(double[] errorOnOutput, double[] layerInput)
        {
            return hiddenLayer.Train(errorOnOutput, layerInput);
        }

        internal void CorrectWeights(double[][] corOutToHidden, double[][] corHiddenToInput, double moment)
        {
            hiddenLayer.LearnLayer(corOutToHidden, moment);
            //inputLayer.LearnLayer(corHiddenToInput, moment);
        }
    }

    public static class Printer
    {
        public static void Print(bool isPrint, double[] o)
        {
            if (isPrint)
            {
                for (int i = 0; i < o.Length; i++)
                {
                    Console.Write(o[i] + "| ");
                }
                Console.WriteLine();
            }
        }

        public static void Print(bool isPrint, string o)
        {
            if (isPrint)
            {
                Console.WriteLine(o);
            }
        }

        public static void Print(bool isPrint, List<double> o)
        {
            if (isPrint)
            {
                for (int i = 0; i < o.Count; i++)
                {
                    Console.Write(o[i] + "| ");
                }
                Console.WriteLine();
            }
        }
    }
}
