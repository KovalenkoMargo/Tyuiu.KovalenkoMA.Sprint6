namespace Tyuiu.KovalenkoMA.Sprint6.Task3.V4
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
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            buttonDone_КМА = new Button();
            buttonHelp_КМА = new Button();
            groupBoxMatrix_КМА = new GroupBox();
            dataGridViewResult_КМА = new DataGridView();
            label_KMA = new Label();
            dataGridViewInput_КМА = new DataGridView();
            groupBox1.SuspendLayout();
            groupBoxMatrix_КМА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_КМА).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_КМА).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 415);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "условие";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 41);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 368);
            textBox2.TabIndex = 0;
            textBox2.Text = "Дан массив 5 на 5 элементов.\r\n-14  -7  18  12 -20\r\n\r\n  -2 -15 -19 -19  -3\r\n\r\n -18  -5 -10  14 -17\r\n\r\n  -1   2 -10   0  11\r\n\r\n   6 -18   0  19  16";
            // 
            // buttonDone_КМА
            // 
            buttonDone_КМА.Location = new Point(621, 398);
            buttonDone_КМА.Name = "buttonDone_КМА";
            buttonDone_КМА.Size = new Size(94, 29);
            buttonDone_КМА.TabIndex = 1;
            buttonDone_КМА.Text = "Выполнить";
            buttonDone_КМА.UseVisualStyleBackColor = true;
            buttonDone_КМА.Click += buttonDone_КМА_Click;
            // 
            // buttonHelp_КМА
            // 
            buttonHelp_КМА.Location = new Point(777, 398);
            buttonHelp_КМА.Name = "buttonHelp_КМА";
            buttonHelp_КМА.Size = new Size(94, 29);
            buttonHelp_КМА.TabIndex = 2;
            buttonHelp_КМА.Text = "?";
            buttonHelp_КМА.UseVisualStyleBackColor = true;
            buttonHelp_КМА.Click += buttonHelp_КМА_Click;
            // 
            // groupBoxMatrix_КМА
            // 
            groupBoxMatrix_КМА.Controls.Add(dataGridViewResult_КМА);
            groupBoxMatrix_КМА.Controls.Add(label_KMA);
            groupBoxMatrix_КМА.Location = new Point(621, 24);
            groupBoxMatrix_КМА.Name = "groupBoxMatrix_КМА";
            groupBoxMatrix_КМА.Size = new Size(250, 368);
            groupBoxMatrix_КМА.TabIndex = 3;
            groupBoxMatrix_КМА.TabStop = false;
            groupBoxMatrix_КМА.Text = "Вывод данных";
            // 
            // dataGridViewResult_КМА
            // 
            dataGridViewResult_КМА.AllowUserToAddRows = false;
            dataGridViewResult_КМА.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_КМА.ColumnHeadersVisible = false;
            dataGridViewResult_КМА.Location = new Point(28, 83);
            dataGridViewResult_КМА.Name = "dataGridViewResult_КМА";
            dataGridViewResult_КМА.RowHeadersVisible = false;
            dataGridViewResult_КМА.RowHeadersWidth = 51;
            dataGridViewResult_КМА.Size = new Size(193, 188);
            dataGridViewResult_КМА.TabIndex = 2;
            // 
            // label_KMA
            // 
            label_KMA.AutoSize = true;
            label_KMA.Location = new Point(25, 40);
            label_KMA.Name = "label_KMA";
            label_KMA.Size = new Size(75, 20);
            label_KMA.TabIndex = 1;
            label_KMA.Text = "Результат";
            // 
            // dataGridViewInput_КМА
            // 
            dataGridViewInput_КМА.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_КМА.Location = new Point(289, 38);
            dataGridViewInput_КМА.Name = "dataGridViewInput_КМА";
            dataGridViewInput_КМА.RowHeadersWidth = 51;
            dataGridViewInput_КМА.Size = new Size(300, 188);
            dataGridViewInput_КМА.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(dataGridViewInput_КМА);
            Controls.Add(groupBoxMatrix_КМА);
            Controls.Add(buttonHelp_КМА);
            Controls.Add(buttonDone_КМА);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxMatrix_КМА.ResumeLayout(false);
            groupBoxMatrix_КМА.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_КМА).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_КМА).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonDone_КМА;
        private Button buttonHelp_КМА;
        private GroupBox groupBoxMatrix_КМА;
        private TextBox textBox2;
        private Label label_KMA;
        private DataGridView dataGridViewResult_КМА;
        private DataGridView dataGridViewInput_КМА;
    }
}
