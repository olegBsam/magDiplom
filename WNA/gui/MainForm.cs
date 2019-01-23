using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WNA.gui;

namespace WNA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            chart1.Series.Clear();
        }

        private void LoadValuesSet_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Controller.GetController.LoadValuesSet(ofd.FileName);
                }
            }
            catch (Exception ex){ Console.WriteLine("ошибка открытия файла: " + ex.StackTrace); }
        }


        private void Learning_ToolStripMenuItem_Click(object sender, EventArgs e) => GuiController.Controller.StartLearningForm(StartTest);

        private void нейToolStripMenuItem_Click(object sender, EventArgs e) => GuiController.Controller.StartInitForm();


        private void SaveNeuralNetwork_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Controller.GetController.SaveNeuroNet(sfd.FileName);
            }
        }

        private void OpenNeuralNetwork_СетьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Controller.GetController.OpenNeuroNet(sfd.FileName);
            }
        }

        private void Test_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartTest();
        }


        private void StartTest()
        {
            double testSetSizePart = double.Parse(testSetPartNUD.Text);
            double classError, error;
            List<double> realOut;
            List<double> learnOut;

            Controller.GetController.Test(out error, out realOut, out learnOut, testSetSizePart);

            chart1.Series.Clear();
            chart1.Series.Add("Learning");
            chart1.Series.Add("Real");

            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Color = Color.Black;
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[1].Color = Color.Red;

            for (int i = 0; i < realOut.Count; i++)
            {
                chart1.Series[0].Points.AddY(learnOut[i]);
                chart1.Series[1].Points.AddY(realOut[i]);
            }

            errorTextBox.Text = error.ToString();
        }

    }
}
