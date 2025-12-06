namespace Tyuiu.KovalenkoMA.Sprint6.Task0.V18
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
            labelInputX_КМА = new Label();
            textBoxInputX_КМА = new TextBox();
            buttonCalculate_КМА = new Button();
            labelResult_КМА = new Label();
            textBoxResult_КМА = new TextBox();
            pictureBoxFormula_КМА = new PictureBox();
            groupBoxInput_КМА = new GroupBox();
            groupBoxOutput_КМА = new GroupBox();
            groupBoxFormula_КМА = new GroupBox();
            labelCondition_КМА = new Label();
            buttonHelp_КМА = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_КМА).BeginInit();
            groupBoxInput_КМА.SuspendLayout();
            groupBoxOutput_КМА.SuspendLayout();
            groupBoxFormula_КМА.SuspendLayout();
            SuspendLayout();
            // 
            // labelInputX_КМА
            // 
            labelInputX_КМА.AutoSize = true;
            labelInputX_КМА.Location = new Point(6, 35);
            labelInputX_КМА.Name = "labelInputX_КМА";
            labelInputX_КМА.Size = new Size(79, 20);
            labelInputX_КМА.TabIndex = 0;
            labelInputX_КМА.Text = "Введите x:";
            // 
            // textBoxInputX_КМА
            // 
            textBoxInputX_КМА.Location = new Point(104, 82);
            textBoxInputX_КМА.Name = "textBoxInputX_КМА";
            textBoxInputX_КМА.Size = new Size(125, 27);
            textBoxInputX_КМА.TabIndex = 1;
            textBoxInputX_КМА.Text = "3";
            // 
            // buttonCalculate_КМА
            // 
            buttonCalculate_КМА.Location = new Point(551, 308);
            buttonCalculate_КМА.Name = "buttonCalculate_КМА";
            buttonCalculate_КМА.Size = new Size(94, 29);
            buttonCalculate_КМА.TabIndex = 2;
            buttonCalculate_КМА.Text = "Вычислить";
            buttonCalculate_КМА.UseVisualStyleBackColor = true;
            buttonCalculate_КМА.Click += buttonCalculate_КМА_Click;
            // 
            // labelResult_КМА
            // 
            labelResult_КМА.AutoSize = true;
            labelResult_КМА.Location = new Point(6, 35);
            labelResult_КМА.Name = "labelResult_КМА";
            labelResult_КМА.Size = new Size(78, 20);
            labelResult_КМА.TabIndex = 3;
            labelResult_КМА.Text = "Результат:";
            // 
            // textBoxResult_КМА
            // 
            textBoxResult_КМА.Location = new Point(99, 82);
            textBoxResult_КМА.Name = "textBoxResult_КМА";
            textBoxResult_КМА.ReadOnly = true;
            textBoxResult_КМА.Size = new Size(125, 27);
            textBoxResult_КМА.TabIndex = 4;
            // 
            // pictureBoxFormula_КМА
            // 
            pictureBoxFormula_КМА.Image = Properties.Resources.unnamed;
            pictureBoxFormula_КМА.Location = new Point(514, 76);
            pictureBoxFormula_КМА.Name = "pictureBoxFormula_КМА";
            pictureBoxFormula_КМА.Size = new Size(125, 62);
            pictureBoxFormula_КМА.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFormula_КМА.TabIndex = 5;
            pictureBoxFormula_КМА.TabStop = false;
            // 
            // groupBoxInput_КМА
            // 
            groupBoxInput_КМА.Controls.Add(labelInputX_КМА);
            groupBoxInput_КМА.Controls.Add(textBoxInputX_КМА);
            groupBoxInput_КМА.Location = new Point(12, 277);
            groupBoxInput_КМА.Name = "groupBoxInput_КМА";
            groupBoxInput_КМА.Size = new Size(250, 125);
            groupBoxInput_КМА.TabIndex = 6;
            groupBoxInput_КМА.TabStop = false;
            groupBoxInput_КМА.Text = "Ввод данных";
            // 
            // groupBoxOutput_КМА
            // 
            groupBoxOutput_КМА.Controls.Add(labelResult_КМА);
            groupBoxOutput_КМА.Controls.Add(textBoxResult_КМА);
            groupBoxOutput_КМА.Location = new Point(295, 277);
            groupBoxOutput_КМА.Name = "groupBoxOutput_КМА";
            groupBoxOutput_КМА.Size = new Size(250, 125);
            groupBoxOutput_КМА.TabIndex = 7;
            groupBoxOutput_КМА.TabStop = false;
            groupBoxOutput_КМА.Text = "Вывод данных";
            // 
            // groupBoxFormula_КМА
            // 
            groupBoxFormula_КМА.Controls.Add(labelCondition_КМА);
            groupBoxFormula_КМА.Location = new Point(18, 12);
            groupBoxFormula_КМА.Name = "groupBoxFormula_КМА";
            groupBoxFormula_КМА.Size = new Size(466, 259);
            groupBoxFormula_КМА.TabIndex = 8;
            groupBoxFormula_КМА.TabStop = false;
            groupBoxFormula_КМА.Text = "Условие";
            // 
            // labelCondition_КМА
            // 
            labelCondition_КМА.AutoSize = true;
            labelCondition_КМА.Location = new Point(6, 39);
            labelCondition_КМА.Name = "labelCondition_КМА";
            labelCondition_КМА.Size = new Size(397, 20);
            labelCondition_КМА.TabIndex = 0;
            labelCondition_КМА.Text = "Вычислить значение функции y = (x³ - 8)/(2x²) при x = 3";
            // 
            // buttonHelp_КМА
            // 
            buttonHelp_КМА.Location = new Point(551, 359);
            buttonHelp_КМА.Name = "buttonHelp_КМА";
            buttonHelp_КМА.Size = new Size(94, 29);
            buttonHelp_КМА.TabIndex = 9;
            buttonHelp_КМА.Text = "?";
            buttonHelp_КМА.UseVisualStyleBackColor = true;
            buttonHelp_КМА.Click += buttonHelp_КМА_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 414);
            Controls.Add(buttonHelp_КМА);
            Controls.Add(groupBoxFormula_КМА);
            Controls.Add(groupBoxOutput_КМА);
            Controls.Add(groupBoxInput_КМА);
            Controls.Add(pictureBoxFormula_КМА);
            Controls.Add(buttonCalculate_КМА);
            Name = "FormMain";
            Text = "Спринт 6 | Task 0 | Вариант 18 | Коваленко М.А.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_КМА).EndInit();
            groupBoxInput_КМА.ResumeLayout(false);
            groupBoxInput_КМА.PerformLayout();
            groupBoxOutput_КМА.ResumeLayout(false);
            groupBoxOutput_КМА.PerformLayout();
            groupBoxFormula_КМА.ResumeLayout(false);
            groupBoxFormula_КМА.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelInputX_КМА;
        private TextBox textBoxInputX_КМА;
        private Button buttonCalculate_КМА;
        private Label labelResult_КМА;
        private TextBox textBoxResult_КМА;
        private PictureBox pictureBoxFormula_КМА;
        private GroupBox groupBoxInput_КМА;
        private GroupBox groupBoxOutput_КМА;
        private GroupBox groupBoxFormula_КМА;
        private Label labelCondition_КМА;
        private Button buttonHelp_КМА;
    }
}
