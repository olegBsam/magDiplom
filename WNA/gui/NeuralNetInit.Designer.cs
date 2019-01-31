namespace WNA
{
    partial class NeuralNetInitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.textBoxinputsCount = new System.Windows.Forms.TextBox();
            this.textBoxHidenNeuronsCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClassCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxHiddenActFunc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboboxOutActFunc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(256, 139);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.Location = new System.Drawing.Point(175, 139);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "Ок";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // textBoxinputsCount
            // 
            this.textBoxinputsCount.Location = new System.Drawing.Point(228, 31);
            this.textBoxinputsCount.Name = "textBoxinputsCount";
            this.textBoxinputsCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxinputsCount.TabIndex = 3;
            this.textBoxinputsCount.Text = "20";
            // 
            // textBoxHidenNeuronsCount
            // 
            this.textBoxHidenNeuronsCount.Location = new System.Drawing.Point(228, 57);
            this.textBoxHidenNeuronsCount.Name = "textBoxHidenNeuronsCount";
            this.textBoxHidenNeuronsCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxHidenNeuronsCount.TabIndex = 4;
            this.textBoxHidenNeuronsCount.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кол-во входов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кол-во нейр. скр. слоя:";
            // 
            // textBoxClassCount
            // 
            this.textBoxClassCount.Location = new System.Drawing.Point(228, 5);
            this.textBoxClassCount.Name = "textBoxClassCount";
            this.textBoxClassCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxClassCount.TabIndex = 2;
            this.textBoxClassCount.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кол-во выходов:";
            // 
            // comboBoxActFunc
            // 
            this.comboBoxHiddenActFunc.FormattingEnabled = true;
            this.comboBoxHiddenActFunc.Location = new System.Drawing.Point(132, 83);
            this.comboBoxHiddenActFunc.Name = "comboBoxActFunc";
            this.comboBoxHiddenActFunc.Size = new System.Drawing.Size(196, 21);
            this.comboBoxHiddenActFunc.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ФА скрыт. слоя:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ФА выходного слоя:";
            // 
            // comboBox1
            // 
            this.comboboxOutActFunc.FormattingEnabled = true;
            this.comboboxOutActFunc.Location = new System.Drawing.Point(132, 110);
            this.comboboxOutActFunc.Name = "comboBox1";
            this.comboboxOutActFunc.Size = new System.Drawing.Size(196, 21);
            this.comboboxOutActFunc.TabIndex = 10;
            // 
            // NeuralNetInitForm
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(340, 171);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboboxOutActFunc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxHiddenActFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxHidenNeuronsCount);
            this.Controls.Add(this.textBoxinputsCount);
            this.Controls.Add(this.textBoxClassCount);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonCancel);
            this.Name = "NeuralNetInitForm";
            this.Text = "NeuralNetInit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.TextBox textBoxinputsCount;
        private System.Windows.Forms.TextBox textBoxHidenNeuronsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClassCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxHiddenActFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboboxOutActFunc;
    }
}