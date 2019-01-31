using MathHelper.Function;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WNA.neural_network;
using WNA.neural_network.Learning;

namespace WNA
{
    public class Controller
    {
        private NeuroNet neuralNetwork;
        private static Controller controller;

        private List<double> dataSet;
        List<KeyValuePair<List<double>, List<double>>> learningSet;
        private double MaxSetValue = double.MinValue;

        public static Controller GetController => controller != null ? controller : controller = new Controller();

        internal void LoadValuesSet(string fileName)
        {
            List<double> dataSetList = new List<double>();
            StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader(new FileStream(fileName, FileMode.Open));
                dataSetList = new List<double>();
                MaxSetValue = double.MinValue;

                while (!streamReader.EndOfStream)
                {
                    var item = double.Parse(streamReader.ReadLine());
                    if (item > MaxSetValue)
                    {
                        MaxSetValue = item;
                    }
                    dataSetList.Add(item);
                }

                var data = dataSetList.ToArray();

                //нормализация
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] /= MaxSetValue; 
                }
                dataSet = data.ToList();


                List<double> previousData = null;
                learningSet = new List<KeyValuePair<List<double>, List<double>>>();
                int max = dataSet.Count - neuralNetwork.InputLayerSize - neuralNetwork.OutputLayerSize;

                for (int i = 0; i < max; i+= neuralNetwork.OutputLayerSize)
                {
                    previousData = new List<double>();
                    for (int k = i; k < neuralNetwork.InputLayerSize + i; k++)
                    {
                        previousData.Add(dataSet.ElementAt(k));
                    }
                       
                    List<double> values = new List<double>();
                    for (int l = 0; l < neuralNetwork.OutputLayerSize; l++)
                    {
                        values.Add(dataSet.ElementAt(i + neuralNetwork.InputLayerSize + l));
                    }
                    learningSet.Add(new KeyValuePair<List<double>, List<double>>(values, previousData));
                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения файла: " + ex.StackTrace);
                if (streamReader != null)
                    streamReader.Close();
            }
        }

        internal void OpenNeuroNet(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            var nn = (NeuroNet)formatter.Deserialize(new FileStream(fileName, FileMode.Open));
            neuralNetwork = nn;
        }

        internal void SaveNeuroNet(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream(fileName, FileMode.CreateNew), neuralNetwork);
        }

        internal void Test(out double fullEror, out List<double> realOut, out List<double> learnOut, double learningSetSizePart)
        {
            int lernSetSize = (int)(learningSet.Count * learningSetSizePart);
            fullEror = 0;

            realOut = new List<double>();
            learnOut = new List<double>();

            var testSet = learningSet.GetRange(learningSet.Count - lernSetSize, lernSetSize);

            List<double> realInput = new List<double>();
            List<double> fullOutputs = new List<double>();

            fullOutputs.AddRange(learningSet[0].Value);
            
            for (int i = 0; i < learningSet[learningSet.Count - lernSetSize].Value.Count; i++)
            {
                realInput.Add(learningSet[learningSet.Count - lernSetSize].Value[i]);
            }

            double error = 0;
            foreach (var item in testSet)
            {
                var output = neuralNetwork.CalculateOutputs(realInput.ToArray());

                realOut.AddRange(output);
                learnOut.AddRange(item.Key);

                fullOutputs.AddRange(output);
               
                for (int i = 0; i < output.Length; i++)
                {
                    error += Math.Pow((output[i] - item.Value[i]), 2);
                }
                realInput.RemoveRange(0, neuralNetwork.OutputLayerSize);
                realInput.AddRange(output);
            }

            fullEror = Math.Sqrt(error);
        }

        internal void StartNeuroNetLearning(Func<double, double, double, int> print, int steps, double coef, double moment, double threesholdErr, double learningSetSizePart)
        {
            new Thread(() =>
            {
                Learning learning = new Learning(learningSet, coef, neuralNetwork, moment);

                for (int i = 0; i < steps; i++)
                {
                    double classError;
                    var err = learning.StartLearning(out classError, learningSetSizePart);
                    print.Invoke(err, (i + 1), classError);
                }
            }).Start();
        }

        internal void CreateNeuronet(int classCount, int inputsCount, int hiddenNeuronsCount, Type hiddenAF, Type outAF)
        {
            neuralNetwork = new NeuroNet(inputsCount, hiddenNeuronsCount, classCount,
                (IActivationFunction)Activator.CreateInstance(hiddenAF),
                (IActivationFunction)Activator.CreateInstance(outAF));
        }

        internal Dictionary<Type, string> GetActivationFunctionTypes()
        {
            var assembly = Assembly.GetAssembly(typeof(ActivationFunctionAttribute));

            Dictionary<Type, string> res = new Dictionary<Type, string>();
            foreach (var type in assembly.GetTypes())
            {
                var attributes = type.GetCustomAttributes(true).Where(atr => atr is ActivationFunctionAttribute).ToList();
                if (attributes.Count() != 0)
                {
                    res.Add(type, ((ActivationFunctionAttribute)attributes.First()).labelName);
                }
            }
            return res;
        }
    }
}
