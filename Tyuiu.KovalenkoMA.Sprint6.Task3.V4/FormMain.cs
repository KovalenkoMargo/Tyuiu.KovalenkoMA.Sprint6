using Tyuiu.KovalenkoMA.Sprint6.Task3.V4.Lib;
using System.Windows.Forms;
namespace Tyuiu.KovalenkoMA.Sprint6.Task3.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            dataGridViewInput_КМА.ColumnCount = 5;   
            dataGridViewInput_КМА.RowCount = 5;      
            dataGridViewResult_КМА.ColumnCount = 5;   
            dataGridViewResult_КМА.RowCount = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridViewInput_КМА.Rows[i].Cells[j].Value = mtrx[i, j];
                }
            }
        }

        DataService ds = new DataService();
        int[,] mtrx = {
            { -14,  -7,  18,  12, -20 },
            {  -2, -15, -19, -19,  -3 },
            { -18,  -5, -10,  14, -17 },
            {  -1,   2, -10,   0,  11 },
            {   6, -18,   0,  19,  16 }
        };

        private void buttonDone_КМА_Click(object sender, EventArgs e)
        {

            try
            {
                int[,] resultMatrix = ds.Calculate(mtrx);
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridViewResult_КМА.Rows[i].Cells[j].Value = resultMatrix[i, j];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_КМА_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ПИНб-25-1 Коваленко Маргарита Александровна",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}

