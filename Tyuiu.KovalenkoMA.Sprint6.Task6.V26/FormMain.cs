using System.Windows.Forms;
using Tyuiu.KovalenkoMA.Sprint6.Task6.V26;
using Tyuiu.KovalenkoMA.Sprint6.Task6.V26.Lib;
namespace Tyuiu.KovalenkoMA.Sprint6.Task6.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonDone_КМА.Enabled = false;
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResult_КМА.Text = ds.CollectTextFromFile(openFilePath);
                buttonDone_КМА.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask_КМА.ShowDialog();

            if (!string.IsNullOrEmpty(openFileDialogTask_КМА.FileName))
            {
                openFilePath = openFileDialogTask_КМА.FileName;  // ← У тебя openFileDialog1, а не openFileDialogTask_КМА
                textBoxLoadFromFile_КМА.Text = File.ReadAllText(openFilePath);  // ← Добавить _КМА
                groupBoxOutput_КМА.Text = groupBoxOutput_КМА.Text + " [" + Path.GetFileName(openFilePath) + "]";  // ← groupBoxOutput_КМА
                buttonDone_КМА.Enabled = true;
            }
        }
       
    }
}
