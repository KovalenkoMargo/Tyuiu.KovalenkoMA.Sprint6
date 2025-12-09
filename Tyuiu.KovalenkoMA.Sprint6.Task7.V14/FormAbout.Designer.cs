namespace Tyuiu.KovalenkoMA.Sprint6.Task7.V14
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelInfo_KMA = new Label();
            pictureBoxPhoto_KMA = new PictureBox();
            buttonOK_KMA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_KMA).BeginInit();
            SuspendLayout();
            // 
            // labelInfo_KMA
            // 
            labelInfo_KMA.AutoSize = true;
            labelInfo_KMA.Location = new Point(226, 9);
            labelInfo_KMA.Name = "labelInfo_KMA";
            labelInfo_KMA.Size = new Size(371, 220);
            labelInfo_KMA.TabIndex = 2;
            labelInfo_KMA.Text = resources.GetString("labelInfo_KMA.Text");
            // 
            // pictureBoxPhoto_KMA
            // 
            pictureBoxPhoto_KMA.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPhoto_KMA.Image = (Image)resources.GetObject("pictureBoxPhoto_KMA.Image");
            pictureBoxPhoto_KMA.Location = new Point(12, 2);
            pictureBoxPhoto_KMA.Name = "pictureBoxPhoto_KMA";
            pictureBoxPhoto_KMA.Size = new Size(184, 330);
            pictureBoxPhoto_KMA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPhoto_KMA.TabIndex = 3;
            pictureBoxPhoto_KMA.TabStop = false;
            // 
            // buttonOK_KMA
            // 
            buttonOK_KMA.DialogResult = DialogResult.OK;
            buttonOK_KMA.Location = new Point(438, 283);
            buttonOK_KMA.Name = "buttonOK_KMA";
            buttonOK_KMA.Size = new Size(94, 29);
            buttonOK_KMA.TabIndex = 4;
            buttonOK_KMA.Text = "ОК";
            buttonOK_KMA.UseVisualStyleBackColor = true;
            buttonOK_KMA.Click += buttonok_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 344);
            Controls.Add(buttonOK_KMA);
            Controls.Add(pictureBoxPhoto_KMA);
            Controls.Add(labelInfo_KMA);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_KMA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo_KMA;
        private PictureBox pictureBoxPhoto_KMA;
        private Button buttonOK_KMA;
    }
}