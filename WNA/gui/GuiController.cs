using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WNA.gui
{
    class GuiController
    {
        private static GuiController controller;
        public static GuiController Controller => controller != null ? controller : controller = new GuiController();

        public void StartLearningForm(Action test) => new LearningForm(test).ShowDialog();

        public void StartInitForm() => new NeuralNetInitForm().ShowDialog();
    }
}
