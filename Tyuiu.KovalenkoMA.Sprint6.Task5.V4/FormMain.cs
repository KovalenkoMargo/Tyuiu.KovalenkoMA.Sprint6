using Tyuiu.KovalenkoMA.Sprint6.Task5.V4.Lib;
namespace Tyuiu.KovalenkoMA.Sprint6.Task5.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\Марго\source\repos\Tyuiu.KovalenkoMA.Sprint6\Tyuiu.KovalenkoMA.Sprint6.Task5.V4\bin\Debug\InPutDataFileTask5V4.txt";

        private void buttonDone_КМА_Click(object sender, EventArgs e)
        {

            try
            {
                dataGridViewNums_КМА.Rows.Clear();
                chartDiag_КМА.Series[0].Points.Clear();

                dataGridViewNums_КМА.ColumnCount = 2;
                dataGridViewNums_КМА.Columns[0].HeaderText = "№";
                dataGridViewNums_КМА.Columns[1].HeaderText = "Значение";
                dataGridViewNums_КМА.Columns[0].Width = 50;
                dataGridViewNums_КМА.Columns[1].Width = 100;
                 
                chartDiag_КМА.Titles.Clear();
                chartDiag_КМА.Titles.Add("Диаграмма значений");
                chartDiag_КМА.ChartAreas[0].AxisX.Title = "Индекс";
                chartDiag_КМА.ChartAreas[0].AxisY.Title = "Значение";

                double[] numsMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewNums_КМА.Rows.Add(i + 1, numsMass[i].ToString("F3"));
                    chartDiag_КМА.Series[0].Points.AddXY(i + 1, numsMass[i]);
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

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments  = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Сбой при открытии файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
