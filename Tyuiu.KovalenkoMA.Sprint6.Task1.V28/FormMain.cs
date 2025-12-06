using Tyuiu.KovalenkoMA.Sprint6.Task1.V28.Lib;
namespace Tyuiu.KovalenkoMA.Sprint6.Task1.V28
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

                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_КМА.Text = "";
                textBoxResult_КМА.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_КМА.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_КМА.AppendText("+----------+----------+" + Environment.NewLine );

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1,5:f2}  |",
                        startStep, valueArray[i]);
                    textBoxResult_КМА.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_КМА.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            textBoxStart_КМА.Text = "-5";
            textBoxStop_КМА.Text = "5";
        }
    }
}