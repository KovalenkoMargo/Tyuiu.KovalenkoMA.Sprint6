namespace Tyuiu.KovalenkoMA.Sprint6.Task7.V14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_КМА = new Panel();
            buttonSaveFile_КМА = new Button();
            buttonDone_КМА = new Button();
            buttonHelp_КМА = new Button();
            buttonOpenFile_КМА = new Button();
            panelMain_КМА = new Panel();
            groupBoxInput_КМА = new GroupBox();
            dataGridViewInMatrix_КМА = new DataGridView();
            panel1 = new Panel();
            panel3 = new Panel();
            groupBoxOutput_КМА = new GroupBox();
            dataGridViewOutMatrix_КМА = new DataGridView();
            splitter1 = new Splitter();
            openFileDialogTask_КМА = new OpenFileDialog();
            toolTipButton_КМА = new ToolTip(components);
            saveFileDialogMatrix_КМА = new OpenFileDialog();
            groupBoxCondition_КМА = new GroupBox();
            labelCondition_КМА = new Label();
            panelTop_КМА.SuspendLayout();
            panelMain_КМА.SuspendLayout();
            groupBoxInput_КМА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_КМА).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxOutput_КМА.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_КМА).BeginInit();
            groupBoxCondition_КМА.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_КМА
            // 
            panelTop_КМА.Controls.Add(buttonSaveFile_КМА);
            panelTop_КМА.Controls.Add(buttonDone_КМА);
            panelTop_КМА.Controls.Add(buttonHelp_КМА);
            panelTop_КМА.Controls.Add(buttonOpenFile_КМА);
            panelTop_КМА.Dock = DockStyle.Top;
            panelTop_КМА.Location = new Point(0, 0);
            panelTop_КМА.Name = "panelTop_КМА";
            panelTop_КМА.Size = new Size(1184, 83);
            panelTop_КМА.TabIndex = 1;
            // 
            // buttonSaveFile_КМА
            // 
            buttonSaveFile_КМА.BackColor = Color.White;
            buttonSaveFile_КМА.Image = (Image)resources.GetObject("buttonSaveFile_КМА.Image");
            buttonSaveFile_КМА.Location = new Point(239, 3);
            buttonSaveFile_КМА.Name = "buttonSaveFile_КМА";
            buttonSaveFile_КМА.Size = new Size(94, 64);
            buttonSaveFile_КМА.TabIndex = 3;
            buttonSaveFile_КМА.TextImageRelation = TextImageRelation.TextBeforeImage;
            toolTipButton_КМА.SetToolTip(buttonSaveFile_КМА, "сохранить файл на компьютер");
            buttonSaveFile_КМА.UseVisualStyleBackColor = false;
            buttonSaveFile_КМА.Click += buttonSaveFile_КМА_Click;
            // 
            // buttonDone_КМА
            // 
            buttonDone_КМА.Image = (Image)resources.GetObject("buttonDone_КМА.Image");
            buttonDone_КМА.Location = new Point(113, 3);
            buttonDone_КМА.Name = "buttonDone_КМА";
            buttonDone_КМА.Size = new Size(94, 64);
            buttonDone_КМА.TabIndex = 2;
            buttonDone_КМА.TextImageRelation = TextImageRelation.TextBeforeImage;
            toolTipButton_КМА.SetToolTip(buttonDone_КМА, "выполнение заданного условия");
            buttonDone_КМА.UseVisualStyleBackColor = true;
            buttonDone_КМА.Click += buttonDone_КМА_Click;
            // 
            // buttonHelp_КМА
            // 
            buttonHelp_КМА.Image = (Image)resources.GetObject("buttonHelp_КМА.Image");
            buttonHelp_КМА.Location = new Point(1039, 12);
            buttonHelp_КМА.Name = "buttonHelp_КМА";
            buttonHelp_КМА.Size = new Size(94, 46);
            buttonHelp_КМА.TabIndex = 1;
            buttonHelp_КМА.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonHelp_КМА.UseVisualStyleBackColor = true;
            buttonHelp_КМА.Click += buttonHelp_КМА_Click;
            // 
            // buttonOpenFile_КМА
            // 
            buttonOpenFile_КМА.Image = (Image)resources.GetObject("buttonOpenFile_КМА.Image");
            buttonOpenFile_КМА.Location = new Point(14, 3);
            buttonOpenFile_КМА.Name = "buttonOpenFile_КМА";
            buttonOpenFile_КМА.Size = new Size(73, 64);
            buttonOpenFile_КМА.TabIndex = 0;
            buttonOpenFile_КМА.Text = "  ";
            buttonOpenFile_КМА.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTipButton_КМА.SetToolTip(buttonOpenFile_КМА, "открыть файл, сохраненный на компьютере");
            buttonOpenFile_КМА.UseVisualStyleBackColor = true;
            buttonOpenFile_КМА.Click += buttonOpenFile_КМА_Click;
            // 
            // panelMain_КМА
            // 
            panelMain_КМА.Controls.Add(groupBoxInput_КМА);
            panelMain_КМА.Dock = DockStyle.Fill;
            panelMain_КМА.Location = new Point(0, 83);
            panelMain_КМА.Name = "panelMain_КМА";
            panelMain_КМА.Size = new Size(1184, 506);
            panelMain_КМА.TabIndex = 2;
            // 
            // groupBoxInput_КМА
            // 
            groupBoxInput_КМА.Controls.Add(dataGridViewInMatrix_КМА);
            groupBoxInput_КМА.Location = new Point(6, 87);
            groupBoxInput_КМА.Name = "groupBoxInput_КМА";
            groupBoxInput_КМА.Size = new Size(614, 388);
            groupBoxInput_КМА.TabIndex = 0;
            groupBoxInput_КМА.TabStop = false;
            groupBoxInput_КМА.Text = "ввод";
            // 
            // dataGridViewInMatrix_КМА
            // 
            dataGridViewInMatrix_КМА.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix_КМА.Location = new Point(8, 30);
            dataGridViewInMatrix_КМА.Name = "dataGridViewInMatrix_КМА";
            dataGridViewInMatrix_КМА.RowHeadersWidth = 51;
            dataGridViewInMatrix_КМА.Size = new Size(600, 296);
            dataGridViewInMatrix_КМА.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxCondition_КМА);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 80);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxOutput_КМА);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(626, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(558, 426);
            panel3.TabIndex = 4;
            // 
            // groupBoxOutput_КМА
            // 
            groupBoxOutput_КМА.Controls.Add(dataGridViewOutMatrix_КМА);
            groupBoxOutput_КМА.Controls.Add(splitter1);
            groupBoxOutput_КМА.Location = new Point(4, 7);
            groupBoxOutput_КМА.Name = "groupBoxOutput_КМА";
            groupBoxOutput_КМА.Size = new Size(542, 400);
            groupBoxOutput_КМА.TabIndex = 0;
            groupBoxOutput_КМА.TabStop = false;
            groupBoxOutput_КМА.Text = "вывод";
            // 
            // dataGridViewOutMatrix_КМА
            // 
            dataGridViewOutMatrix_КМА.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix_КМА.Location = new Point(16, 29);
            dataGridViewOutMatrix_КМА.Name = "dataGridViewOutMatrix_КМА";
            dataGridViewOutMatrix_КМА.RowHeadersWidth = 51;
            dataGridViewOutMatrix_КМА.Size = new Size(520, 297);
            dataGridViewOutMatrix_КМА.TabIndex = 2;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(3, 23);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 374);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask_КМА
            // 
            openFileDialogTask_КМА.FileName = "openFileDialog1";
            // 
            // saveFileDialogMatrix_КМА
            // 
            saveFileDialogMatrix_КМА.FileName = "openFileDialog1";
            // 
            // groupBoxCondition_КМА
            // 
            groupBoxCondition_КМА.Controls.Add(labelCondition_КМА);
            groupBoxCondition_КМА.Location = new Point(14, 6);
            groupBoxCondition_КМА.Name = "groupBoxCondition_КМА";
            groupBoxCondition_КМА.Size = new Size(1131, 64);
            groupBoxCondition_КМА.TabIndex = 0;
            groupBoxCondition_КМА.TabStop = false;
            groupBoxCondition_КМА.Text = "условие";
            // 
            // labelCondition_КМА
            // 
            labelCondition_КМА.AutoSize = true;
            labelCondition_КМА.Location = new Point(15, 25);
            labelCondition_КМА.Name = "labelCondition_КМА";
            labelCondition_КМА.Size = new Size(512, 20);
            labelCondition_КМА.TabIndex = 0;
            labelCondition_КМА.Text = "Загрузить CSV файл, изменить во второй строке четные элементы на 44";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 589);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panelMain_КМА);
            Controls.Add(panelTop_КМА);
            Name = "FormMain";
            Text = "Спринт 6 / Таск 7 / Вариант 14 / Коваленко М.А.";
            panelTop_КМА.ResumeLayout(false);
            panelMain_КМА.ResumeLayout(false);
            groupBoxInput_КМА.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_КМА).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBoxOutput_КМА.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_КМА).EndInit();
            groupBoxCondition_КМА.ResumeLayout(false);
            groupBoxCondition_КМА.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_КМА;
        private Button buttonDone_КМА;
        private Button buttonHelp_КМА;
        private Button buttonOpenFile_КМА;
        private Panel panelMain_КМА;
        private GroupBox groupBoxInput_КМА;
        private Panel panel1;
        private Panel panel3;
        private GroupBox groupBoxOutput_КМА;
        private Splitter splitter1;
        private OpenFileDialog openFileDialogTask_КМА;
        private DataGridView dataGridViewInMatrix_КМА;
        private DataGridView dataGridViewOutMatrix_КМА;
        private ToolTip toolTipButton_КМА;
        private Button buttonSaveFile_КМА;
        private OpenFileDialog saveFileDialogMatrix_КМА;
        private GroupBox groupBoxCondition_КМА;
        private Label labelCondition_КМА;
    }
}
