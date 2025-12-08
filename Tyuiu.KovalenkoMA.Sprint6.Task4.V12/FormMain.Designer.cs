namespace Tyuiu.KovalenkoMA.Sprint6.Task4.V12
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel_KMA = new Panel();
            groupBoxInput_КМА = new GroupBox();
            textBoxStop_КМА = new TextBox();
            textBoxStart_КМА = new TextBox();
            labelStop_КМА = new Label();
            labelStart_КМА = new Label();
            groupBoxCondition_КМА = new GroupBox();
            labelCondition_КМА = new Label();
            buttonHelp_КМА = new Button();
            buttonSave_КМА = new Button();
            buttonDone_КМА = new Button();
            panel2_KMA = new Panel();
            groupBoxOutput_КМА = new GroupBox();
            textBoxResult_КМА = new TextBox();
            panel3_KMA = new Panel();
            chartFunction_КМА = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panel_KMA.SuspendLayout();
            groupBoxInput_КМА.SuspendLayout();
            groupBoxCondition_КМА.SuspendLayout();
            panel2_KMA.SuspendLayout();
            groupBoxOutput_КМА.SuspendLayout();
            panel3_KMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_КМА).BeginInit();
            SuspendLayout();
            // 
            // panel_KMA
            // 
            panel_KMA.BackColor = SystemColors.AppWorkspace;
            panel_KMA.Controls.Add(groupBoxInput_КМА);
            panel_KMA.Controls.Add(groupBoxCondition_КМА);
            panel_KMA.Controls.Add(buttonHelp_КМА);
            panel_KMA.Controls.Add(buttonSave_КМА);
            panel_KMA.Controls.Add(buttonDone_КМА);
            panel_KMA.Dock = DockStyle.Top;
            panel_KMA.Location = new Point(0, 0);
            panel_KMA.Name = "panel_KMA";
            panel_KMA.Size = new Size(982, 71);
            panel_KMA.TabIndex = 0;
            // 
            // groupBoxInput_КМА
            // 
            groupBoxInput_КМА.Controls.Add(textBoxStop_КМА);
            groupBoxInput_КМА.Controls.Add(textBoxStart_КМА);
            groupBoxInput_КМА.Controls.Add(labelStop_КМА);
            groupBoxInput_КМА.Controls.Add(labelStart_КМА);
            groupBoxInput_КМА.Location = new Point(365, 3);
            groupBoxInput_КМА.Name = "groupBoxInput_КМА";
            groupBoxInput_КМА.Size = new Size(334, 68);
            groupBoxInput_КМА.TabIndex = 1;
            groupBoxInput_КМА.TabStop = false;
            groupBoxInput_КМА.Text = "ввод данных";
            // 
            // textBoxStop_КМА
            // 
            textBoxStop_КМА.Location = new Point(189, 38);
            textBoxStop_КМА.Name = "textBoxStop_КМА";
            textBoxStop_КМА.Size = new Size(125, 27);
            textBoxStop_КМА.TabIndex = 3;
            textBoxStop_КМА.Text = "5";
            // 
            // textBoxStart_КМА
            // 
            textBoxStart_КМА.Location = new Point(25, 38);
            textBoxStart_КМА.Name = "textBoxStart_КМА";
            textBoxStart_КМА.Size = new Size(125, 27);
            textBoxStart_КМА.TabIndex = 2;
            textBoxStart_КМА.Text = "-5";
            // 
            // labelStop_КМА
            // 
            labelStop_КМА.AutoSize = true;
            labelStop_КМА.Location = new Point(189, 15);
            labelStop_КМА.Name = "labelStop_КМА";
            labelStop_КМА.Size = new Size(51, 20);
            labelStop_КМА.TabIndex = 1;
            labelStop_КМА.Text = "конец";
            // 
            // labelStart_КМА
            // 
            labelStart_КМА.AutoSize = true;
            labelStart_КМА.Location = new Point(25, 18);
            labelStart_КМА.Name = "labelStart_КМА";
            labelStart_КМА.Size = new Size(59, 20);
            labelStart_КМА.TabIndex = 0;
            labelStart_КМА.Text = "начало";
            // 
            // groupBoxCondition_КМА
            // 
            groupBoxCondition_КМА.Controls.Add(labelCondition_КМА);
            groupBoxCondition_КМА.Location = new Point(4, 3);
            groupBoxCondition_КМА.Name = "groupBoxCondition_КМА";
            groupBoxCondition_КМА.Size = new Size(355, 68);
            groupBoxCondition_КМА.TabIndex = 3;
            groupBoxCondition_КМА.TabStop = false;
            groupBoxCondition_КМА.Text = "условие";
            // 
            // labelCondition_КМА
            // 
            labelCondition_КМА.AutoSize = true;
            labelCondition_КМА.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCondition_КМА.Location = new Point(14, 21);
            labelCondition_КМА.Name = "labelCondition_КМА";
            labelCondition_КМА.Size = new Size(320, 18);
            labelCondition_КМА.TabIndex = 0;
            labelCondition_КМА.Text = "F(x) = sin(x) + 2/(3x+0.5) - 2cos(x)*2x";
            // 
            // buttonHelp_КМА
            // 
            buttonHelp_КМА.BackColor = Color.Yellow;
            buttonHelp_КМА.Location = new Point(791, 3);
            buttonHelp_КМА.Name = "buttonHelp_КМА";
            buttonHelp_КМА.Size = new Size(94, 29);
            buttonHelp_КМА.TabIndex = 2;
            buttonHelp_КМА.Text = "?";
            buttonHelp_КМА.UseVisualStyleBackColor = false;
            buttonHelp_КМА.Click += buttonHelp_КМА_Click;
            // 
            // buttonSave_КМА
            // 
            buttonSave_КМА.BackColor = Color.FromArgb(128, 255, 255);
            buttonSave_КМА.Location = new Point(885, 38);
            buttonSave_КМА.Name = "buttonSave_КМА";
            buttonSave_КМА.Size = new Size(94, 29);
            buttonSave_КМА.TabIndex = 1;
            buttonSave_КМА.Text = "сохранить";
            buttonSave_КМА.UseVisualStyleBackColor = false;
            buttonSave_КМА.Click += buttonSave_KMA_Click;
            // 
            // buttonDone_КМА
            // 
            buttonDone_КМА.BackColor = Color.RosyBrown;
            buttonDone_КМА.Location = new Point(705, 39);
            buttonDone_КМА.Name = "buttonDone_КМА";
            buttonDone_КМА.Size = new Size(94, 29);
            buttonDone_КМА.TabIndex = 0;
            buttonDone_КМА.Text = "выполнить";
            buttonDone_КМА.UseVisualStyleBackColor = false;
            buttonDone_КМА.Click += buttonDone_КМА_Click;
            // 
            // panel2_KMA
            // 
            panel2_KMA.BackColor = SystemColors.ButtonShadow;
            panel2_KMA.Controls.Add(groupBoxOutput_КМА);
            panel2_KMA.Dock = DockStyle.Left;
            panel2_KMA.Location = new Point(0, 71);
            panel2_KMA.Name = "panel2_KMA";
            panel2_KMA.Size = new Size(250, 382);
            panel2_KMA.TabIndex = 1;
            // 
            // groupBoxOutput_КМА
            // 
            groupBoxOutput_КМА.Controls.Add(textBoxResult_КМА);
            groupBoxOutput_КМА.Dock = DockStyle.Fill;
            groupBoxOutput_КМА.Location = new Point(0, 0);
            groupBoxOutput_КМА.Name = "groupBoxOutput_КМА";
            groupBoxOutput_КМА.Size = new Size(250, 382);
            groupBoxOutput_КМА.TabIndex = 0;
            groupBoxOutput_КМА.TabStop = false;
            groupBoxOutput_КМА.Text = "вывод данных";
            // 
            // textBoxResult_КМА
            // 
            textBoxResult_КМА.Dock = DockStyle.Fill;
            textBoxResult_КМА.Location = new Point(3, 23);
            textBoxResult_КМА.Multiline = true;
            textBoxResult_КМА.Name = "textBoxResult_КМА";
            textBoxResult_КМА.ScrollBars = ScrollBars.Vertical;
            textBoxResult_КМА.Size = new Size(244, 356);
            textBoxResult_КМА.TabIndex = 1;
            // 
            // panel3_KMA
            // 
            panel3_KMA.BackColor = SystemColors.ControlDarkDark;
            panel3_KMA.Controls.Add(chartFunction_КМА);
            panel3_KMA.Controls.Add(splitter1);
            panel3_KMA.Dock = DockStyle.Fill;
            panel3_KMA.Location = new Point(250, 71);
            panel3_KMA.Name = "panel3_KMA";
            panel3_KMA.Size = new Size(732, 382);
            panel3_KMA.TabIndex = 2;
            // 
            // chartFunction_КМА
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_КМА.ChartAreas.Add(chartArea1);
            chartFunction_КМА.Dock = DockStyle.Fill;
            chartFunction_КМА.Location = new Point(4, 0);
            chartFunction_КМА.Name = "chartFunction_КМА";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chartFunction_КМА.Series.Add(series1);
            chartFunction_КМА.Size = new Size(728, 382);
            chartFunction_КМА.TabIndex = 1;
            chartFunction_КМА.Text = "chart1";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 382);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 453);
            Controls.Add(panel3_KMA);
            Controls.Add(panel2_KMA);
            Controls.Add(panel_KMA);
            MinimumSize = new Size(444, 220);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 / Коваленко М.А.";
            panel_KMA.ResumeLayout(false);
            groupBoxInput_КМА.ResumeLayout(false);
            groupBoxInput_КМА.PerformLayout();
            groupBoxCondition_КМА.ResumeLayout(false);
            groupBoxCondition_КМА.PerformLayout();
            panel2_KMA.ResumeLayout(false);
            groupBoxOutput_КМА.ResumeLayout(false);
            groupBoxOutput_КМА.PerformLayout();
            panel3_KMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_КМА).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_KMA;
        private GroupBox groupBoxCondition_КМА;
        private Button buttonHelp_КМА;
        private Button buttonSave_КМА;
        private Button buttonDone_КМА;
        private Panel panel2_KMA;
        private Panel panel3_KMA;
        private Splitter splitter1;
        private GroupBox groupBoxInput_КМА;
        private TextBox textBoxStop_КМА;
        private TextBox textBoxStart_КМА;
        private Label labelStop_КМА;
        private Label labelStart_КМА;
        private GroupBox groupBoxOutput_КМА;
        private TextBox textBoxResult_КМА;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_КМА;
        private Label labelCondition_КМА;
    }
}
