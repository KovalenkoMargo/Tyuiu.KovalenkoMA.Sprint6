using Tyuiu.KovalenkoMA.Sprint6.Task7.V14.Lib;
namespace Tyuiu.KovalenkoMA.Sprint6.Task7.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonDone_КМА.Enabled = false;
            buttonSaveFile_КМА.Enabled = false;
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            // Разделение на строки
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            // Определяем количество строк и столбцов
            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            // Выделяем массив данных
            int[,] arrayValues = new int[rows, columns];

            // Заполняем массив данными
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        // ===========================================================================

        // ============= КНОПКА "ОТКРЫТЬ ФАЙЛ" =============
        private void buttonOpenFile_КМА_Click(object sender, EventArgs e)
        {
            openFileDialogTask_КМА.ShowDialog();
            openFilePath = openFileDialogTask_КМА.FileName;

            // Загружаем данные из файла
            int[,] arrayValues = LoadFromFileData(openFilePath);

            // Настраиваем таблицы (размеры)
            dataGridViewInMatrix_КМА.ColumnCount = columns;
            dataGridViewInMatrix_КМА.RowCount = rows;
            dataGridViewOutMatrix_КМА.ColumnCount = columns;
            dataGridViewOutMatrix_КМА.RowCount = rows;
            buttonDone_КМА.Enabled = true;
            buttonSaveFile_КМА.Enabled = true;

            // Настраиваем ширину столбцов
            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix_КМА.Columns[i].Width = 50;
                dataGridViewOutMatrix_КМА.Columns[i].Width = 50;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix_КМА.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            // Активируем кнопку "Выполнить"
            buttonDone_КМА.Enabled = true;
        }
        private void buttonDone_КМА_Click(object sender, EventArgs e)
        {
            // Получаем измененную матрицу из библиотеки
            int[,] resultMatrix = ds.GetMatrix(openFilePath);

            // Заполняем ВЫХОДНУЮ таблицу (dataGridViewOut)
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutMatrix_КМА.Rows[r].Cells[c].Value = resultMatrix[r, c];
                }
            }

            // Активируем кнопку "Сохранить"
            buttonSaveFile_КМА.Enabled = true;
        }
        private void buttonSaveFile_КМА_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_КМА.FileName = "OutPutFileTask7V14.csv";
            saveFileDialogMatrix_КМА.InitialDirectory = Directory.GetCurrentDirectory();

            if (saveFileDialogMatrix_КМА.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialogMatrix_КМА.FileName;

                // Удаляем существующий файл
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                // Сохраняем данные в CSV
                int rowsCount = dataGridViewOutMatrix_КМА.RowCount;
                int columnsCount = dataGridViewOutMatrix_КМА.ColumnCount;

                string str = "";
                for (int i = 0; i < rowsCount; i++)
                {
                    for (int j = 0; j < columnsCount; j++)
                    {
                        if (j != columnsCount - 1)
                        {
                            str = str + dataGridViewOutMatrix_КМА.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewOutMatrix_КМА.Rows[i].Cells[j].Value;
                        }
                    }

                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }

                MessageBox.Show("Файл сохранен: " + path,
                    "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonHelp_КМА_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        // ===========================================

        // ============= ДОПОЛНИТЕЛЬНО (ToolTip как у преподавателя) =============
        private void buttonOpenFile_КМА_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_КМА.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_КМА_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_КМА.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_КМА_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_КМА.ToolTipTitle = "Сохранить в файл";
        }
        private void buttonHelp_КМА_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_КМА.ToolTipTitle = "Справка";
        }

        private void groupBoxInput_КМА_Enter(object sender, EventArgs e)
        {

        }
    }
}
