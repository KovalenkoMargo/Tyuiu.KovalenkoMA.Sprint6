namespace Tyuiu.KovalenkoMA.Sprint6.Task2.V1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartFunction_КМА = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxOutput_КМА = new GroupBox();
            dataGridViewFunction_КМА = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBoxInput_КМА = new GroupBox();
            textBoxStart_КМА = new TextBox();
            textBoxStop_КМА = new TextBox();
            labelStop_КМА = new Label();
            labelStart_КМА = new Label();
            groupBoxCondition_КМА = new GroupBox();
            labelCondition_КМА = new Label();
            buttonDone_КМА = new Button();
            buttonHelp_КМА = new Button();
            ((System.ComponentModel.ISupportInitialize)chartFunction_КМА).BeginInit();
            groupBoxOutput_КМА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_КМА).BeginInit();
            groupBoxInput_КМА.SuspendLayout();
            groupBoxCondition_КМА.SuspendLayout();
            SuspendLayout();
            // 
            // chartFunction_КМА
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction_КМА.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            chartFunction_КМА.Legends.Add(legend2);
            chartFunction_КМА.Location = new Point(770, 41);
            chartFunction_КМА.Name = "chartFunction_КМА";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction_КМА.Series.Add(series2);
            chartFunction_КМА.Size = new Size(375, 375);
            chartFunction_КМА.TabIndex = 0;
            // 
            // groupBoxOutput_КМА
            // 
            groupBoxOutput_КМА.Controls.Add(dataGridViewFunction_КМА);
            groupBoxOutput_КМА.Location = new Point(477, 12);
            groupBoxOutput_КМА.Name = "groupBoxOutput_КМА";
            groupBoxOutput_КМА.Size = new Size(287, 426);
            groupBoxOutput_КМА.TabIndex = 1;
            groupBoxOutput_КМА.TabStop = false;
            groupBoxOutput_КМА.Text = "Вывод данных";
            // 
            // dataGridViewFunction_КМА
            // 
            dataGridViewFunction_КМА.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_КМА.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewFunction_КМА.Location = new Point(11, 28);
            dataGridViewFunction_КМА.Name = "dataGridViewFunction_КМА";
            dataGridViewFunction_КМА.RowHeadersVisible = false;
            dataGridViewFunction_КМА.RowHeadersWidth = 51;
            dataGridViewFunction_КМА.Size = new Size(270, 392);
            dataGridViewFunction_КМА.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(x)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // groupBoxInput_КМА
            // 
            groupBoxInput_КМА.Controls.Add(textBoxStart_КМА);
            groupBoxInput_КМА.Controls.Add(textBoxStop_КМА);
            groupBoxInput_КМА.Controls.Add(labelStop_КМА);
            groupBoxInput_КМА.Controls.Add(labelStart_КМА);
            groupBoxInput_КМА.Location = new Point(12, 249);
            groupBoxInput_КМА.Name = "groupBoxInput_КМА";
            groupBoxInput_КМА.Size = new Size(434, 125);
            groupBoxInput_КМА.TabIndex = 2;
            groupBoxInput_КМА.TabStop = false;
            groupBoxInput_КМА.Text = "Ввод данных";
            // 
            // textBoxStart_КМА
            // 
            textBoxStart_КМА.Location = new Point(19, 79);
            textBoxStart_КМА.Name = "textBoxStart_КМА";
            textBoxStart_КМА.Size = new Size(125, 27);
            textBoxStart_КМА.TabIndex = 3;
            textBoxStart_КМА.Text = "-5";
            // 
            // textBoxStop_КМА
            // 
            textBoxStop_КМА.Location = new Point(254, 74);
            textBoxStop_КМА.Name = "textBoxStop_КМА";
            textBoxStop_КМА.Size = new Size(125, 27);
            textBoxStop_КМА.TabIndex = 2;
            textBoxStop_КМА.Text = "5";
            // 
            // labelStop_КМА
            // 
            labelStop_КМА.AutoSize = true;
            labelStop_КМА.Location = new Point(247, 32);
            labelStop_КМА.Name = "labelStop_КМА";
            labelStop_КМА.Size = new Size(53, 20);
            labelStop_КМА.TabIndex = 1;
            labelStop_КМА.Text = "Конец";
            // 
            // labelStart_КМА
            // 
            labelStart_КМА.AutoSize = true;
            labelStart_КМА.Location = new Point(15, 30);
            labelStart_КМА.Name = "labelStart_КМА";
            labelStart_КМА.Size = new Size(61, 20);
            labelStart_КМА.TabIndex = 0;
            labelStart_КМА.Text = "Начало";
            // 
            // groupBoxCondition_КМА
            // 
            groupBoxCondition_КМА.Controls.Add(labelCondition_КМА);
            groupBoxCondition_КМА.Location = new Point(12, 12);
            groupBoxCondition_КМА.Name = "groupBoxCondition_КМА";
            groupBoxCondition_КМА.Size = new Size(459, 231);
            groupBoxCondition_КМА.TabIndex = 3;
            groupBoxCondition_КМА.TabStop = false;
            groupBoxCondition_КМА.Text = "Условие";
            // 
            // labelCondition_КМА
            // 
            labelCondition_КМА.AutoSize = true;
            labelCondition_КМА.Location = new Point(11, 36);
            labelCondition_КМА.Name = "labelCondition_КМА";
            labelCondition_КМА.Size = new Size(524, 20);
            labelCondition_КМА.TabIndex = 0;
            labelCondition_КМА.Text = "Табулировать функцию F(x) = cos(x) + sin(x)/(2-2x) - 4x на диапазоне [-5;5]";
            // 
            // buttonDone_КМА
            // 
            buttonDone_КМА.Location = new Point(51, 402);
            buttonDone_КМА.Name = "buttonDone_КМА";
            buttonDone_КМА.Size = new Size(94, 29);
            buttonDone_КМА.TabIndex = 4;
            buttonDone_КМА.Text = "Выполнить";
            buttonDone_КМА.UseVisualStyleBackColor = true;
            buttonDone_КМА.Click += buttonDone_КМА_Click;
            // 
            // buttonHelp_КМА
            // 
            buttonHelp_КМА.Location = new Point(276, 402);
            buttonHelp_КМА.Name = "buttonHelp_КМА";
            buttonHelp_КМА.Size = new Size(94, 29);
            buttonHelp_КМА.TabIndex = 5;
            buttonHelp_КМА.Text = "?";
            buttonHelp_КМА.UseVisualStyleBackColor = true;
            buttonHelp_КМА.Click += buttonHelp_КМА_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 450);
            Controls.Add(buttonHelp_КМА);
            Controls.Add(buttonDone_КМА);
            Controls.Add(groupBoxCondition_КМА);
            Controls.Add(groupBoxInput_КМА);
            Controls.Add(groupBoxOutput_КМА);
            Controls.Add(chartFunction_КМА);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)chartFunction_КМА).EndInit();
            groupBoxOutput_КМА.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_КМА).EndInit();
            groupBoxInput_КМА.ResumeLayout(false);
            groupBoxInput_КМА.PerformLayout();
            groupBoxCondition_КМА.ResumeLayout(false);
            groupBoxCondition_КМА.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_КМА;
        private GroupBox groupBoxOutput_КМА;
        private GroupBox groupBoxInput_КМА;
        private Label labelStop_КМА;
        private Label labelStart_КМА;
        private GroupBox groupBoxCondition_КМА;
        private Label labelCondition_КМА;
        private Button buttonDone_КМА;
        private Button buttonHelp_КМА;
        private TextBox textBoxStart_КМА;
        private TextBox textBoxStop_КМА;
        private DataGridView dataGridViewFunction_КМА;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
