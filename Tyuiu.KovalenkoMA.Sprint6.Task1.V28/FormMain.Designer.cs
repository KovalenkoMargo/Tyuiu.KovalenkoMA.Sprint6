namespace Tyuiu.KovalenkoMA.Sprint6.Task1.V28
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
            textBoxResult_КМА = new TextBox();
            textBoxStart_КМА = new TextBox();
            textBoxStop_КМА = new TextBox();
            buttonHelp_КМА = new Button();
            buttonCalculate_КМА = new Button();
            groupBoxInput_КМА = new GroupBox();
            labelStart_КМА = new Label();
            labelStop_КМА = new Label();
            groupBoxOutput_КМА = new GroupBox();
            groupBoxControl_КМА = new GroupBox();
            labelCondition_КМА = new Label();
            groupBoxInput_КМА.SuspendLayout();
            groupBoxOutput_КМА.SuspendLayout();
            groupBoxControl_КМА.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxResult_КМА
            // 
            textBoxResult_КМА.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_КМА.Location = new Point(5, 26);
            textBoxResult_КМА.Multiline = true;
            textBoxResult_КМА.Name = "textBoxResult_КМА";
            textBoxResult_КМА.ReadOnly = true;
            textBoxResult_КМА.ScrollBars = ScrollBars.Vertical;
            textBoxResult_КМА.Size = new Size(302, 381);
            textBoxResult_КМА.TabIndex = 0;
            // 
            // textBoxStart_КМА
            // 
            textBoxStart_КМА.Location = new Point(22, 77);
            textBoxStart_КМА.Name = "textBoxStart_КМА";
            textBoxStart_КМА.Size = new Size(125, 27);
            textBoxStart_КМА.TabIndex = 1;
            textBoxStart_КМА.Text = "-5";
            // 
            // textBoxStop_КМА
            // 
            textBoxStop_КМА.Location = new Point(184, 75);
            textBoxStop_КМА.Name = "textBoxStop_КМА";
            textBoxStop_КМА.Size = new Size(125, 27);
            textBoxStop_КМА.TabIndex = 2;
            textBoxStop_КМА.Text = "5";
            // 
            // buttonHelp_КМА
            // 
            buttonHelp_КМА.BackColor = Color.ForestGreen;
            buttonHelp_КМА.Location = new Point(414, 390);
            buttonHelp_КМА.Name = "buttonHelp_КМА";
            buttonHelp_КМА.Size = new Size(103, 29);
            buttonHelp_КМА.TabIndex = 3;
            buttonHelp_КМА.Text = "?";
            buttonHelp_КМА.UseVisualStyleBackColor = false;
            buttonHelp_КМА.Click += buttonHelp_КМА_Click;
            // 
            // buttonCalculate_КМА
            // 
            buttonCalculate_КМА.BackColor = Color.Cyan;
            buttonCalculate_КМА.Location = new Point(414, 329);
            buttonCalculate_КМА.Name = "buttonCalculate_КМА";
            buttonCalculate_КМА.Size = new Size(103, 29);
            buttonCalculate_КМА.TabIndex = 4;
            buttonCalculate_КМА.Text = "Выполнить";
            buttonCalculate_КМА.UseVisualStyleBackColor = false;
            buttonCalculate_КМА.Click += buttonDone_КМА_Click;
            // 
            // groupBoxInput_КМА
            // 
            groupBoxInput_КМА.Controls.Add(labelStart_КМА);
            groupBoxInput_КМА.Controls.Add(labelStop_КМА);
            groupBoxInput_КМА.Controls.Add(textBoxStop_КМА);
            groupBoxInput_КМА.Controls.Add(textBoxStart_КМА);
            groupBoxInput_КМА.Location = new Point(28, 313);
            groupBoxInput_КМА.Name = "groupBoxInput_КМА";
            groupBoxInput_КМА.Size = new Size(345, 125);
            groupBoxInput_КМА.TabIndex = 5;
            groupBoxInput_КМА.TabStop = false;
            groupBoxInput_КМА.Text = "Ввод данных";
            // 
            // labelStart_КМА
            // 
            labelStart_КМА.AutoSize = true;
            labelStart_КМА.Location = new Point(22, 40);
            labelStart_КМА.Name = "labelStart_КМА";
            labelStart_КМА.Size = new Size(143, 20);
            labelStart_КМА.TabIndex = 4;
            labelStart_КМА.Text = "Начало диапазона:";
            // 
            // labelStop_КМА
            // 
            labelStop_КМА.AutoSize = true;
            labelStop_КМА.Location = new Point(184, 40);
            labelStop_КМА.Name = "labelStop_КМА";
            labelStop_КМА.Size = new Size(135, 20);
            labelStop_КМА.TabIndex = 3;
            labelStop_КМА.Text = "Конец диапазона:";
            // 
            // groupBoxOutput_КМА
            // 
            groupBoxOutput_КМА.Controls.Add(textBoxResult_КМА);
            groupBoxOutput_КМА.Location = new Point(549, 24);
            groupBoxOutput_КМА.Name = "groupBoxOutput_КМА";
            groupBoxOutput_КМА.Size = new Size(250, 427);
            groupBoxOutput_КМА.TabIndex = 6;
            groupBoxOutput_КМА.TabStop = false;
            groupBoxOutput_КМА.Text = "Вывод данных";
            // 
            // groupBoxControl_КМА
            // 
            groupBoxControl_КМА.Controls.Add(labelCondition_КМА);
            groupBoxControl_КМА.Location = new Point(28, 39);
            groupBoxControl_КМА.Name = "groupBoxControl_КМА";
            groupBoxControl_КМА.Size = new Size(515, 268);
            groupBoxControl_КМА.TabIndex = 7;
            groupBoxControl_КМА.TabStop = false;
            groupBoxControl_КМА.Text = "Условие";
            // 
            // labelCondition_КМА
            // 
            labelCondition_КМА.AutoSize = true;
            labelCondition_КМА.Location = new Point(6, 23);
            labelCondition_КМА.Name = "labelCondition_КМА";
            labelCondition_КМА.Size = new Size(596, 20);
            labelCondition_КМА.TabIndex = 0;
            labelCondition_КМА.Text = "Табулирование функции F(x) = cos(x) + 4x/2 - sin(x)*3x на диапазоне [-5;5] с шагом 1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 450);
            Controls.Add(groupBoxControl_КМА);
            Controls.Add(groupBoxOutput_КМА);
            Controls.Add(groupBoxInput_КМА);
            Controls.Add(buttonCalculate_КМА);
            Controls.Add(buttonHelp_КМА);
            Name = "FormMain";
            Text = "Form1";
            groupBoxInput_КМА.ResumeLayout(false);
            groupBoxInput_КМА.PerformLayout();
            groupBoxOutput_КМА.ResumeLayout(false);
            groupBoxOutput_КМА.PerformLayout();
            groupBoxControl_КМА.ResumeLayout(false);
            groupBoxControl_КМА.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxResult_КМА;
        private TextBox textBoxStart_КМА;
        private TextBox textBoxStop_КМА;
        private Button buttonHelp_КМА;
        private Button buttonCalculate_КМА;
        private GroupBox groupBoxInput_КМА;
        private GroupBox groupBoxOutput_КМА;
        private GroupBox groupBoxControl_КМА;
        private Label labelStart_КМА;
        private Label labelStop_КМА;
        private Label labelCondition_КМА;
    }
}
