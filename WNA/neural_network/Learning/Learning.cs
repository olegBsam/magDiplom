using System;
using System.Linq;
using System.Collections.Generic;

namespace WNA.neural_network.Learning
{
    public class Learning
    {
        List<KeyValuePair<List<double>, List<double>>> learningSet;
        NeuroNet neuroNet;
        Dictionary<int, Dictionary<int, double>> log = new Dictionary<int, Dictionary<int, double>>();
        private double alpha;
        private double moment;

        public Learning(List<KeyValuePair<List<double>, List<double>>> dataSet, double learnCoef, NeuroNet neuroNet, double moment)
        {
            this.moment = moment;
            alpha = learnCoef;
            this.neuroNet = neuroNet;
            learningSet = dataSet;
        }

        static Random rand = new Random();


        public double StartLearning( out double classError, double learningSetSizePart)
        {
            double fullEror = 0;
            double error = 0;
            classError = 0;

            int lernSetSize = (int)(learningSet.Count * learningSetSizePart);

            List<double> realInput = new List<double>();
            List<double> fullOutputs = new List<double>();

            fullOutputs.AddRange(learningSet[0].Value);

            for (int i = 0; i < learningSet[0].Value.Count; i++)
            {
                realInput.Add(learningSet[0].Value[i]);
            }

            for (int i = 0; i < lernSetSize; i++)
            {
                var output = LearningOnOneClass(out error, learningSet[i].Value.ToArray(), realInput.ToArray()).ToList();

                fullOutputs.AddRange(output);
                fullEror += error;

                realInput.RemoveRange(0, neuroNet.OutputLayerSize);
                realInput.AddRange(output);
               
            }

            error = Math.Sqrt(fullEror);

            return fullEror;
        }


        //обучение на одном классе
        private double[] LearningOnOneClass(out double error, double[] nextValues, double[] inputVector)
        {
            neuroNet.CalculateOutputs(inputVector);

            double[] iLOutput = neuroNet.InputLayerOutput;
            double[] hLOutput = neuroNet.HiddenLayerOutput;
            double[] oLOutput = neuroNet.OutputLayerOutput;

            double[] hLInput = neuroNet.HiddenLayerInput;
            double[] oLInput = neuroNet.OutputLayerInput;


            //Ошибка на выходе сети
            double[] errorOnOutput = neuroNet.TrainOutputLayer(oLOutput, learnOutput: nextValues, layerInput: oLInput).ToArray();

            //Величины корректировки каждой связи межд вых и скр слоем
            double[][] corOutToHidden = GetWeightCorrect(errorOnOutput, hLOutput);

            //Ошибка между вых и скрытым слоем
            double[] errorOnHidden = neuroNet.TrainHiddenLayer(errorOnOutput, hLInput);

            //Величины корректировки каждой связи межд скр и вх слоем
            double[][] corHiddenToInput = GetWeightCorrect(errorOnHidden, iLOutput);

            neuroNet.CorrectWeights(corOutToHidden, corHiddenToInput, moment);

            error = 0;

            for (int i = 0; i < oLOutput.Length; i++)
            {
                error += Math.Pow((oLOutput[i] - nextValues[i]), 2);
            }

            error = Math.Sqrt(error);

            return oLOutput;
        }



        //Величины корректировки каждой связи межд вых и скр слоем
        private double[][] GetWeightCorrect(double[] errors, double[] prevLayerOutputs)
        {
            double[][] correct = new double[prevLayerOutputs.Length][];

            //Для нейрона смещения
            correct[0] = new double[errors.Length];
            for (int i = 0; i < errors.Length; i++)
            {
                correct[0][i] = alpha * errors[i];
            }

            //для остальных
            for (int j = 1; j < prevLayerOutputs.Length; j++)
            {
                correct[j] = new double[errors.Length];

                for (int k = 0; k < errors.Length; k++)
                {
                    correct[j][k] = alpha * errors[k] * prevLayerOutputs[j];//корректировка для каждой связи каждого нейрона скрытого слоя (между скрытым и выход)
                }
            }

            return correct;
        }
    }
}