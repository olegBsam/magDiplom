namespace WNA.gui
{
    partial class LearningForm
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
            this.learningCoef_NUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.stepsCount_NUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.learningSetPartNUD = new System.Windows.Forms.NumericUpDown();
            this.momentsUsedGroupBox = new System.Windows.Forms.GroupBox();
            this.moment_NUD = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.startLearningButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.classErrTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.currentErrorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentIterationTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.learningCoef_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsCount_NUD)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.learningSetPartNUD)).BeginInit();
            this.momentsUsedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moment_NUD)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // learningCoef_NUD
            // 
            this.learningCoef_NUD.DecimalPlaces = 3;
            this.learningCoef_NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.learningCoef_NUD.Location = new System.Drawing.Point(6, 31);
            this.learningCoef_NUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.learningCoef_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.learningCoef_NUD.Name = "learningCoef_NUD";
            this.learningCoef_NUD.Size = new System.Drawing.Size(120, 20);
            this.learningCoef_NUD.TabIndex = 0;
            this.learningCoef_NUD.Value = new decimal(new int[] {
            35,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Коэф. обучения:";
            // 
            // stepsCount_NUD
            // 
            this.stepsCount_NUD.Location = new System.Drawing.Point(6, 181);
            this.stepsCount_NUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.stepsCount_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepsCount_NUD.Name = "stepsCount_NUD";
            this.stepsCount_NUD.Size = new System.Drawing.Size(120, 20);
            this.stepsCount_NUD.TabIndex = 2;
            this.stepsCount_NUD.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кол-во эпох:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.learningSetPartNUD);
            this.groupBox1.Controls.Add(this.momentsUsedGroupBox);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.startLearningButton);
            this.groupBox1.Controls.Add(this.learningCoef_NUD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stepsCount_NUD);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 244);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры обучения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Доля обуч выборки:";
            // 
            // learningSetPartNUD
            // 
            this.learningSetPartNUD.DecimalPlaces = 2;
            this.learningSetPartNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.learningSetPartNUD.Location = new System.Drawing.Point(6, 131);
            this.learningSetPartNUD.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.learningSetPartNUD.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.learningSetPartNUD.Name = "learningSetPartNUD";
            this.learningSetPartNUD.Size = new System.Drawing.Size(120, 20);
            this.learningSetPartNUD.TabIndex = 12;
            this.learningSetPartNUD.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // momentsUsedGroupBox
            // 
            this.momentsUsedGroupBox.Controls.Add(this.moment_NUD);
            this.momentsUsedGroupBox.Enabled = false;
            this.momentsUsedGroupBox.Location = new System.Drawing.Point(6, 70);
            this.momentsUsedGroupBox.Name = "momentsUsedGroupBox";
            this.momentsUsedGroupBox.Size = new System.Drawing.Size(127, 43);
            this.momentsUsedGroupBox.TabIndex = 11;
            this.momentsUsedGroupBox.TabStop = false;
            this.momentsUsedGroupBox.Text = "Значение момента:";
            // 
            // moment_NUD
            // 
            this.moment_NUD.DecimalPlaces = 3;
            this.moment_NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.moment_NUD.Location = new System.Drawing.Point(5, 17);
            this.moment_NUD.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.moment_NUD.Name = "moment_NUD";
            this.moment_NUD.Size = new System.Drawing.Size(115, 20);
            this.moment_NUD.TabIndex = 7;
            this.moment_NUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Исп. моменты";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.IsUsedMomentsMethod_CheckedChanged);
            // 
            // startLearningButton
            // 
            this.startLearningButton.Location = new System.Drawing.Point(58, 207);
            this.startLearningButton.Name = "startLearningButton";
            this.startLearningButton.Size = new System.Drawing.Size(75, 23);
            this.startLearningButton.TabIndex = 6;
            this.startLearningButton.Text = "Обучить";
            this.startLearningButton.UseVisualStyleBackColor = true;
            this.startLearningButton.Click += new System.EventHandler(this.startLearningButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(324, 247);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Закрыть";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.classErrTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.currentErrorTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.currentIterationTextBox);
            this.groupBox2.Location = new System.Drawing.Point(157, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 226);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Состояние обучения";
            // 
            // classErrTextBox
            // 
            this.classErrTextBox.Location = new System.Drawing.Point(10, 139);
            this.classErrTextBox.Name = "classErrTextBox";
            this.classErrTextBox.Size = new System.Drawing.Size(158, 20);
            this.classErrTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Погрешность классификации:";
            // 
            // currentErrorTextBox
            // 
            this.currentErrorTextBox.Location = new System.Drawing.Point(9, 87);
            this.currentErrorTextBox.Name = "currentErrorTextBox";
            this.currentErrorTextBox.Size = new System.Drawing.Size(159, 20);
            this.currentErrorTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Текущая значение ошибки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Текущая итерация:";
            // 
            // currentIterationTextBox
            // 
            this.currentIterationTextBox.Location = new System.Drawing.Point(6, 37);
            this.currentIterationTextBox.Name = "currentIterationTextBox";
            this.currentIterationTextBox.Size = new System.Drawing.Size(162, 20);
            this.currentIterationTextBox.TabIndex = 0;
            // 
            // LearningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(411, 282);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "LearningForm";
            this.Text = "LearningForm";
            ((System.ComponentModel.ISupportInitialize)(this.learningCoef_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsCount_NUD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.learningSetPartNUD)).EndInit();
            this.momentsUsedGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moment_NUD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown learningCoef_NUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown stepsCount_NUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button startLearningButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox currentIterationTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currentErrorTextBox;
        private System.Windows.Forms.NumericUpDown moment_NUD;
        private System.Windows.Forms.TextBox classErrTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox momentsUsedGroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown learningSetPartNUD;
    }
}