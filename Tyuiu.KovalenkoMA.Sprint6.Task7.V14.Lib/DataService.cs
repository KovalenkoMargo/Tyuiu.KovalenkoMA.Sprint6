using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KovalenkoMA.Sprint6.Task7.V14.Lib
{
    public class DataService : ISprint6Task7V14
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            // 2. Определяем размеры матрицы
            int rows = lines.Length;
            string[] firstLine = lines[0].Split(';');
            int cols = firstLine.Length;

            int[,] matrix = new int[rows, cols];

            // 3. Заполняем матрицу
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            // 4. ИЗМЕНЕНИЕ: Вторая строка (индекс 1), четные элементы → 44
            int secondRow = 1; // Вторая строка
            for (int j = 0; j < cols; j++)
            {
                if (matrix[secondRow, j] % 2 == 0) // если четное
                {
                    matrix[secondRow, j] = 44; // заменяем на 44
                }
            }

            return matrix;
        }
    }
}
