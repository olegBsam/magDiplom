namespace WNA
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фалйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьСетьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьСетьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.роToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обучениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.testSetPartNUD = new System.Windows.Forms.NumericUpDown();
            this.classErrTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testSetPartNUD)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фалйToolStripMenuItem,
            this.нейToolStripMenuItem,
            this.роToolStripMenuItem,
            this.обучениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фалйToolStripMenuItem
            // 
            this.фалйToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьДанныеToolStripMenuItem,
            this.загрузитьСетьToolStripMenuItem,
            this.сохранитьСетьToolStripMenuItem});
            this.фалйToolStripMenuItem.Name = "фалйToolStripMenuItem";
            this.фалйToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.фалйToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьДанныеToolStripMenuItem
            // 
            this.загрузитьДанныеToolStripMenuItem.Name = "загрузитьДанныеToolStripMenuItem";
            this.загрузитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.загрузитьДанныеToolStripMenuItem.Text = "Загрузить данные";
            this.загрузитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.LoadValuesSet_ToolStripMenuItem_Click);
            // 
            // загрузитьСетьToolStripMenuItem
            // 
            this.загрузитьСетьToolStripMenuItem.Name = "загрузитьСетьToolStripMenuItem";
            this.загрузитьСетьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.загрузитьСетьToolStripMenuItem.Text = "Загрузить сеть";
            this.загрузитьСетьToolStripMenuItem.Click += new System.EventHandler(this.OpenNeuralNetwork_СетьToolStripMenuItem_Click);
            // 
            // сохранитьСетьToolStripMenuItem
            // 
            this.сохранитьСетьToolStripMenuItem.Name = "сохранитьСетьToolStripMenuItem";
            this.сохранитьСетьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.сохранитьСетьToolStripMenuItem.Text = "Сохранить сеть";
            this.сохранитьСетьToolStripMenuItem.Click += new System.EventHandler(this.SaveNeuralNetwork_ToolStripMenuItem_Click);
            // 
            // нейToolStripMenuItem
            // 
            this.нейToolStripMenuItem.Name = "нейToolStripMenuItem";
            this.нейToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.нейToolStripMenuItem.Text = "Инициализировать";
            this.нейToolStripMenuItem.Click += new System.EventHandler(this.нейToolStripMenuItem_Click);
            // 
            // роToolStripMenuItem
            // 
            this.роToolStripMenuItem.Name = "роToolStripMenuItem";
            this.роToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.роToolStripMenuItem.Text = "Тест";
            this.роToolStripMenuItem.Click += new System.EventHandler(this.Test_ToolStripMenuItem_Click);
            // 
            // обучениеToolStripMenuItem
            // 
            this.обучениеToolStripMenuItem.Name = "обучениеToolStripMenuItem";
            this.обучениеToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.обучениеToolStripMenuItem.Text = "Обучение";
            this.обучениеToolStripMenuItem.Click += new System.EventHandler(this.Learning_ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Доля тест. выборки:";
            // 
            // testSetPartNUD
            // 
            this.testSetPartNUD.DecimalPlaces = 2;
            this.testSetPartNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.testSetPartNUD.Location = new System.Drawing.Point(130, 39);
            this.testSetPartNUD.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.testSetPartNUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.testSetPartNUD.Name = "testSetPartNUD";
            this.testSetPartNUD.Size = new System.Drawing.Size(54, 20);
            this.testSetPartNUD.TabIndex = 13;
            this.testSetPartNUD.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // classErrTextBox
            // 
            this.classErrTextBox.Location = new System.Drawing.Point(16, 142);
            this.classErrTextBox.Name = "classErrTextBox";
            this.classErrTextBox.Size = new System.Drawing.Size(158, 20);
            this.classErrTextBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Погрешность классификации:";
            // 
            // errorTextBox
            // 
            this.errorTextBox.Location = new System.Drawing.Point(15, 90);
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.Size = new System.Drawing.Size(159, 20);
            this.errorTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Значение ошибки:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(199, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 346);
            this.panel1.TabIndex = 18;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(486, 340);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.classErrTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.errorTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.testSetPartNUD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Многослойный персептрон";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testSetPartNUD)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фалйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem роToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обучениеToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown testSetPartNUD;
        private System.Windows.Forms.TextBox classErrTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox errorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem загрузитьСетьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьСетьToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

