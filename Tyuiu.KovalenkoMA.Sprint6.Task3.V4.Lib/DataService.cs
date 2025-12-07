using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KovalenkoMA.Sprint6.Task3.V4.Lib
{
    public class DataService : ISprint6Task3V4
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);   
            int columns = matrix.GetLength(1); 

            int[,] resultMatrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    resultMatrix[i, j] = matrix[i, j];
                }
            }
            int secondRow = 1;

            for (int j = 0; j < columns; j++)
            {
                if (resultMatrix[secondRow, j] % 2 == 0)
                {
                    resultMatrix[secondRow, j] = 0;
                }
            }

            return resultMatrix;
        }
    }
}
