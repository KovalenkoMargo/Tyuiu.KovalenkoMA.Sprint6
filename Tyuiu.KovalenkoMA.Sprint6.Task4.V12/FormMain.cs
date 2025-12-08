using System.Windows.Forms;
using Tyuiu.KovalenkoMA.Sprint6.Task4.V12.Lib;
namespace Tyuiu.KovalenkoMA.Sprint6.Task4.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_КМА_Click(object sender, EventArgs e)
        {

            try
            {

                int startStep = Convert.ToInt32(textBoxStart_КМА.Text);
                int stopStep = Convert.ToInt32(textBoxStop_КМА.Text);


                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                chartFunction_КМА.Titles.Clear();
                this.chartFunction_КМА.Titles.Add("График функции");
                this.chartFunction_КМА.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_КМА.ChartAreas[0].AxisY.Title = "Ось Ү";

                textBoxResult_КМА.Text = "";
                chartFunction_КМА.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.textBoxResult_КМА.AppendText($"x = {startStep} -> F(x) = {valueArray[i]:F2}{Environment.NewLine}");
                    this.chartFunction_КМА.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
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

        private void buttonSave_KMA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_КМА.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно! \n Открыть его в блокноте?", "Сообщение", MessageBoxButtons. YesNo, MessageBoxIcon. Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
