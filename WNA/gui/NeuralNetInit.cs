using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WNA
{
    public partial class NeuralNetInitForm : Form
    {
        public NeuralNetInitForm()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            int classCount = int.Parse(textBoxClassCount.Text);
            int inputsCount = int.Parse(textBoxinputsCount.Text);
            int hidenNeuronsCount = int.Parse(textBoxHidenNeuronsCount.Text);

            Controller.GetController.CreateNeuronet(classCount: classCount, inputsCount: inputsCount, hiddenNeuronsCount: hidenNeuronsCount);
            this.Close();
        }

    }
}
