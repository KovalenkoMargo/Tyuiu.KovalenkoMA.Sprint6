namespace Tyuiu.KovalenkoMA.Sprint6.Task6.V26
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
            components = new System.ComponentModel.Container();
            panelTop_КМА = new Panel();
            buttonDone_КМА = new Button();
            buttonHelp_КМА = new Button();
            buttonOpenFile_КМА = new Button();
            panelMain_КМА = new Panel();
            groupBoxInput_КМА = new GroupBox();
            textBoxLoadFromFile_КМА = new TextBox();
            panel3 = new Panel();
            groupBoxOutput_КМА = new GroupBox();
            textBoxResult_КМА = new TextBox();
            groupBoxCondition_КМА = new GroupBox();
            labelTask_КМА = new Label();
            openFileDialogTask_КМА = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            panelTop_КМА.SuspendLayout();
            panelMain_КМА.SuspendLayout();
            groupBoxInput_КМА.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxOutput_КМА.SuspendLayout();
            groupBoxCondition_КМА.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_КМА
            // 
            panelTop_КМА.Controls.Add(buttonDone_КМА);
            panelTop_КМА.Controls.Add(buttonHelp_КМА);
            panelTop_КМА.Controls.Add(buttonOpenFile_КМА);
            panelTop_КМА.Dock = DockStyle.Top;
            panelTop_КМА.Location = new Point(0, 0);
            panelTop_КМА.Name = "panelTop_КМА";
            panelTop_КМА.Size = new Size(1028, 97);
            panelTop_КМА.TabIndex = 0;
            // 
            // buttonDone_КМА
            // 
            buttonDone_КМА.Location = new Point(121, 47);
            buttonDone_КМА.Name = "buttonDone_КМА";
            buttonDone_КМА.Size = new Size(94, 29);
            buttonDone_КМА.TabIndex = 2;
            buttonDone_КМА.Text = "результат";
            toolTip1.SetToolTip(buttonDone_КМА, "выполнить");
            buttonDone_КМА.UseVisualStyleBackColor = true;
            buttonDone_КМА.Click += buttonDone_Click;
            // 
            // buttonHelp_КМА
            // 
            buttonHelp_КМА.Location = new Point(922, 19);
            buttonHelp_КМА.Name = "buttonHelp_КМА";
            buttonHelp_КМА.Size = new Size(94, 29);
            buttonHelp_КМА.TabIndex = 1;
            buttonHelp_КМА.Text = "?";
            toolTip1.SetToolTip(buttonHelp_КМА, "справка");
            buttonHelp_КМА.UseVisualStyleBackColor = true;
            buttonHelp_КМА.Click += buttonHelp_Click;
            // 
            // buttonOpenFile_КМА
            // 
            buttonOpenFile_КМА.Image = Properties.Resources.folder;
            buttonOpenFile_КМА.Location = new Point(16, 40);
            buttonOpenFile_КМА.Name = "buttonOpenFile_КМА";
            buttonOpenFile_КМА.Size = new Size(65, 43);
            buttonOpenFile_КМА.TabIndex = 0;
            buttonOpenFile_КМА.Text = "  ";
            buttonOpenFile_КМА.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(buttonOpenFile_КМА, "открыть файл");
            buttonOpenFile_КМА.UseVisualStyleBackColor = true;
            buttonOpenFile_КМА.Click += buttonOpenFile_Click;
            // 
            // panelMain_КМА
            // 
            panelMain_КМА.Controls.Add(groupBoxInput_КМА);
            panelMain_КМА.Location = new Point(0, 174);
            panelMain_КМА.Name = "panelMain_КМА";
            panelMain_КМА.Size = new Size(535, 322);
            panelMain_КМА.TabIndex = 1;
            // 
            // groupBoxInput_КМА
            // 
            groupBoxInput_КМА.Controls.Add(textBoxLoadFromFile_КМА);
            groupBoxInput_КМА.Location = new Point(6, 7);
            groupBoxInput_КМА.Name = "groupBoxInput_КМА";
            groupBoxInput_КМА.Size = new Size(526, 315);
            groupBoxInput_КМА.TabIndex = 0;
            groupBoxInput_КМА.TabStop = false;
            groupBoxInput_КМА.Text = "ввод";
            // 
            // textBoxLoadFromFile_КМА
            // 
            textBoxLoadFromFile_КМА.Location = new Point(10, 30);
            textBoxLoadFromFile_КМА.Multiline = true;
            textBoxLoadFromFile_КМА.Name = "textBoxLoadFromFile_КМА";
            textBoxLoadFromFile_КМА.ReadOnly = true;
            textBoxLoadFromFile_КМА.ScrollBars = ScrollBars.Vertical;
            textBoxLoadFromFile_КМА.Size = new Size(510, 278);
            textBoxLoadFromFile_КМА.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxOutput_КМА);
            panel3.Location = new Point(553, 174);
            panel3.Name = "panel3";
            panel3.Size = new Size(475, 322);
            panel3.TabIndex = 2;
            // 
            // groupBoxOutput_КМА
            // 
            groupBoxOutput_КМА.Controls.Add(textBoxResult_КМА);
            groupBoxOutput_КМА.Location = new Point(4, 7);
            groupBoxOutput_КМА.Name = "groupBoxOutput_КМА";
            groupBoxOutput_КМА.Size = new Size(468, 312);
            groupBoxOutput_КМА.TabIndex = 0;
            groupBoxOutput_КМА.TabStop = false;
            groupBoxOutput_КМА.Text = "вывод";
            // 
            // textBoxResult_КМА
            // 
            textBoxResult_КМА.Location = new Point(6, 30);
            textBoxResult_КМА.Multiline = true;
            textBoxResult_КМА.Name = "textBoxResult_КМА";
            textBoxResult_КМА.ScrollBars = ScrollBars.Vertical;
            textBoxResult_КМА.Size = new Size(449, 278);
            textBoxResult_КМА.TabIndex = 0;
            // 
            // groupBoxCondition_КМА
            // 
            groupBoxCondition_КМА.Controls.Add(labelTask_КМА);
            groupBoxCondition_КМА.Location = new Point(12, 103);
            groupBoxCondition_КМА.Name = "groupBoxCondition_КМА";
            groupBoxCondition_КМА.Size = new Size(1000, 65);
            groupBoxCondition_КМА.TabIndex = 0;
            groupBoxCondition_КМА.TabStop = false;
            groupBoxCondition_КМА.Text = "условие";
            // 
            // labelTask_КМА
            // 
            labelTask_КМА.AutoSize = true;
            labelTask_КМА.Location = new Point(14, 24);
            labelTask_КМА.Name = "labelTask_КМА";
            labelTask_КМА.Size = new Size(360, 20);
            labelTask_КМА.TabIndex = 0;
            labelTask_КМА.Text = "Считать последнее слово из каждой строки файла";
            // 
            // openFileDialogTask_КМА
            // 
            openFileDialogTask_КМА.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 501);
            Controls.Add(groupBoxCondition_КМА);
            Controls.Add(panel3);
            Controls.Add(panelMain_КМА);
            Controls.Add(panelTop_КМА);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 / Таск 6 / Вариант 26 / Коваленко М.А.";
            panelTop_КМА.ResumeLayout(false);
            panelMain_КМА.ResumeLayout(false);
            groupBoxInput_КМА.ResumeLayout(false);
            groupBoxInput_КМА.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxOutput_КМА.ResumeLayout(false);
            groupBoxOutput_КМА.PerformLayout();
            groupBoxCondition_КМА.ResumeLayout(false);
            groupBoxCondition_КМА.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_КМА;
        private Panel panelMain_КМА;
        private Panel panel3;
        private GroupBox groupBoxCondition_КМА;
        private Label labelTask_КМА;
        private GroupBox groupBoxInput_КМА;
        private TextBox textBoxLoadFromFile_КМА;
        private OpenFileDialog openFileDialogTask_КМА;
        private Button buttonDone_КМА;
        private Button buttonHelp_КМА;
        private Button buttonOpenFile_КМА;
        private ToolTip toolTip1;
        private GroupBox groupBoxOutput_КМА;
        private TextBox textBoxResult_КМА;
    }
}
