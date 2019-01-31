using MathHelper.Function;
using MathHelper.Function.NotRbf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WNA
{
    public partial class NeuralNetInitForm : Form
    {
        private Dictionary<Type, string> types;
        public NeuralNetInitForm()
        {
            InitializeComponent();
            types = Controller.GetController.GetActivationFunctionTypes();
            comboBoxHiddenActFunc.Items.AddRange(types.Values.ToArray());
            comboBoxHiddenActFunc.SelectedIndex = 0;
            comboBoxHiddenActFunc.DropDownStyle = ComboBoxStyle.DropDownList;

            comboboxOutActFunc.Items.AddRange(types.Values.ToArray());
            comboboxOutActFunc.SelectedIndex = 0;
            comboboxOutActFunc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            int classCount = int.Parse(textBoxClassCount.Text);
            int inputsCount = int.Parse(textBoxinputsCount.Text);

            Type hiddenAF = types.Single(vp => vp.Value.Equals(comboBoxHiddenActFunc.SelectedItem)).Key;
            Type outAF = types.Single(vp => vp.Value.Equals(comboboxOutActFunc.SelectedItem)).Key;

            Controller.GetController.CreateNeuronet(classCount: classCount, inputsCount: inputsCount, hiddenNeuronsCount: inputsCount, hiddenAF: hiddenAF, outAF: outAF);
            this.Close();
        }

    }
}
