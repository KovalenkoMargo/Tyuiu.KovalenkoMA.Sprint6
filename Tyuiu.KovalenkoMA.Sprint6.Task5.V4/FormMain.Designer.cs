namespace Tyuiu.KovalenkoMA.Sprint6.Task5.V4
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelCondition_КМА = new Panel();
            buttonHelp_КМА = new Button();
            buttonOpenFile_КМА = new Button();
            buttonDone_КМА = new Button();
            groupBoxCondition_КМА = new GroupBox();
            labelCondition_КМАlabelCondition_КМА = new Label();
            panelData_КМА = new Panel();
            groupBox2 = new GroupBox();
            dataGridViewNums_КМА = new DataGridView();
            splitter1 = new Splitter();
            panel1 = new Panel();
            chartDiag_КМА = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelCondition_КМА.SuspendLayout();
            groupBoxCondition_КМА.SuspendLayout();
            panelData_КМА.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_КМА).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_КМА).BeginInit();
            SuspendLayout();
            // 
            // panelCondition_КМА
            // 
            panelCondition_КМА.Controls.Add(buttonHelp_КМА);
            panelCondition_КМА.Controls.Add(buttonOpenFile_КМА);
            panelCondition_КМА.Controls.Add(buttonDone_КМА);
            panelCondition_КМА.Controls.Add(groupBoxCondition_КМА);
            panelCondition_КМА.Dock = DockStyle.Top;
            panelCondition_КМА.Location = new Point(0, 0);
            panelCondition_КМА.Name = "panelCondition_КМА";
            panelCondition_КМА.Size = new Size(982, 85);
            panelCondition_КМА.TabIndex = 0;
            // 
            // buttonHelp_КМА
            // 
            buttonHelp_КМА.Location = new Point(862, 39);
            buttonHelp_КМА.Name = "buttonHelp_КМА";
            buttonHelp_КМА.Size = new Size(94, 29);
            buttonHelp_КМА.TabIndex = 3;
            buttonHelp_КМА.Text = "?";
            buttonHelp_КМА.UseVisualStyleBackColor = true;
            buttonHelp_КМА.Click += buttonHelp_КМА_Click;
            // 
            // buttonOpenFile_КМА
            // 
            buttonOpenFile_КМА.Location = new Point(717, 39);
            buttonOpenFile_КМА.Name = "buttonOpenFile_КМА";
            buttonOpenFile_КМА.Size = new Size(94, 29);
            buttonOpenFile_КМА.TabIndex = 2;
            buttonOpenFile_КМА.Text = "открыть файл";
            buttonOpenFile_КМА.UseVisualStyleBackColor = true;
            buttonOpenFile_КМА.Click += buttonOpenFile_Click;
            // 
            // buttonDone_КМА
            // 
            buttonDone_КМА.Location = new Point(571, 39);
            buttonDone_КМА.Name = "buttonDone_КМА";
            buttonDone_КМА.Size = new Size(94, 29);
            buttonDone_КМА.TabIndex = 1;
            buttonDone_КМА.Text = "выполнить";
            buttonDone_КМА.UseVisualStyleBackColor = true;
            buttonDone_КМА.Click += buttonDone_КМА_Click;
            // 
            // groupBoxCondition_КМА
            // 
            groupBoxCondition_КМА.Controls.Add(labelCondition_КМАlabelCondition_КМА);
            groupBoxCondition_КМА.Location = new Point(12, 3);
            groupBoxCondition_КМА.Name = "groupBoxCondition_КМА";
            groupBoxCondition_КМА.Size = new Size(513, 79);
            groupBoxCondition_КМА.TabIndex = 0;
            groupBoxCondition_КМА.TabStop = false;
            groupBoxCondition_КМА.Text = "условие";
            // 
            // labelCondition_КМАlabelCondition_КМА
            // 
            labelCondition_КМАlabelCondition_КМА.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCondition_КМАlabelCondition_КМА.Location = new Point(11, 23);
            labelCondition_КМАlabelCondition_КМА.Name = "labelCondition_КМАlabelCondition_КМА";
            labelCondition_КМАlabelCondition_КМА.Size = new Size(492, 53);
            labelCondition_КМАlabelCondition_КМА.TabIndex = 0;
            labelCondition_КМАlabelCondition_КМА.Text = "Прочитать данные из файла InPutFileTask5V4.txt. Вывести целые числа, вещественные округлить до 3 знаков";
            // 
            // panelData_КМА
            // 
            panelData_КМА.Controls.Add(groupBox2);
            panelData_КМА.Dock = DockStyle.Left;
            panelData_КМА.Location = new Point(0, 85);
            panelData_КМА.Name = "panelData_КМА";
            panelData_КМА.Size = new Size(250, 368);
            panelData_КМА.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewNums_КМА);
            groupBox2.Location = new Point(3, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 359);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dataGridViewNums_КМА
            // 
            dataGridViewNums_КМА.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_КМА.Location = new Point(4, 24);
            dataGridViewNums_КМА.Name = "dataGridViewNums_КМА";
            dataGridViewNums_КМА.RowHeadersWidth = 51;
            dataGridViewNums_КМА.Size = new Size(234, 329);
            dataGridViewNums_КМА.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(250, 85);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 368);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(chartDiag_КМА);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(254, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 368);
            panel1.TabIndex = 4;
            // 
            // chartDiag_КМА
            // 
            chartArea2.Name = "ChartArea1";
            chartDiag_КМА.ChartAreas.Add(chartArea2);
            chartDiag_КМА.Location = new Point(6, 6);
            chartDiag_КМА.Name = "chartDiag_КМА";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            chartDiag_КМА.Series.Add(series2);
            chartDiag_КМА.Size = new Size(719, 359);
            chartDiag_КМА.TabIndex = 0;
            chartDiag_КМА.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 453);
            Controls.Add(panel1);
            Controls.Add(splitter1);
            Controls.Add(panelData_КМА);
            Controls.Add(panelCondition_КМА);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 / Таск 5 / Коваленко М.А.";
            panelCondition_КМА.ResumeLayout(false);
            groupBoxCondition_КМА.ResumeLayout(false);
            panelData_КМА.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_КМА).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag_КМА).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCondition_КМА;
        private Panel panelData_КМА;
        private GroupBox groupBoxCondition_КМА;
        private GroupBox groupBox2;
        private Label labelCondition_КМАlabelCondition_КМА;
        private Button buttonHelp_КМА;
        private Button buttonOpenFile_КМА;
        private Button buttonDone_КМА;
        private Splitter splitter1;
        private Panel panel1;
        private DataGridView dataGridViewNums_КМА;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_КМА;
    }
}
