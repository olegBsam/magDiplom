using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WNA.gui
{
    public partial class LearningForm : Form
    {
        public LearningForm(Action test)
        {
            InitializeComponent();
            this.test = test;
        }

        private Action test;
        private string statiscticsFileName = "statisctics.txt";
        private string statiscticsFilePath = string.Empty;

        private void IsUsedMomentsMethod_CheckedChanged(object sender, EventArgs e) => momentsUsedGroupBox.Enabled = (sender as CheckBox).Checked;


        private int PrintOutputs(double err, double currEpoch, double classErr)
        {
            try
            {
                Invoke((MethodInvoker)delegate ()
                {
                    currentIterationTextBox.Text = currEpoch.ToString();
                    currentErrorTextBox.Text = err.ToString();
                    classErrTextBox.Text = classErr.ToString();
                });
            }
            catch { }
            return 1;
        }


        private void startLearningButton_Click(object sender, EventArgs e)
        {
            //100 - это эпох, 0.5 - коэф обуч
            double learningCoef = double.Parse(learningCoef_NUD.Text);
            double moment = 0;

            if (checkBox1.Checked)
            {
                moment = double.Parse(moment_NUD.Text);
            }
            
            int epochCount = int.Parse(stepsCount_NUD.Text);
            double learningSetSizePart = double.Parse(learningSetPartNUD.Text);
            double threesholdErr = 0.0;

            Controller.GetController.StartNeuroNetLearning(PrintOutputs, epochCount, learningCoef, moment, threesholdErr, learningSetSizePart);
        }

        private void SaveStatiscticsChanged()
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.FileName = statiscticsFileName;
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                statiscticsFilePath = ofd.FileName;
            }
        }

        private void SaveToFileChecked_CheckedChanged(object sender, EventArgs e)
        {
            if (statiscticsFilePath == string.Empty && (sender as CheckBox).Checked)
            {
                SaveStatiscticsChanged();
            }
        }

        private void ChangeStatisticsFilePath_Click(object sender, EventArgs e)
        {
            SaveStatiscticsChanged();
        }
    }
}
