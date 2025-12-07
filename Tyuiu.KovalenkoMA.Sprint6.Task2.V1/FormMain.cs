using Tyuiu.KovalenkoMA.Sprint6.Task2.V1.Lib;
using System.Windows.Forms.DataVisualization.Charting;
namespace Tyuiu.KovalenkoMA.Sprint6.Task2.V1
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

                this.chartFunction_КМА.Titles.Add("График функции");
                this.chartFunction_КМА.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_КМА.ChartAreas[0].AxisY.Title = "Ось Ү";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_КМА.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            //
        }


    }
}
