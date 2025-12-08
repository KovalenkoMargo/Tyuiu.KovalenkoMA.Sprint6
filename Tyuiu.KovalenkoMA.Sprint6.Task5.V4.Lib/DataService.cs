using tyuiu.cources.programming.interfaces.Sprint6;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.KovalenkoMA.Sprint6.Task5.V4.Lib
{
    public class DataService : ISprint6Task5V4 
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] allLines = File.ReadAllLines(path);
            double[] numbers = new double[allLines.Length];

            for (int i = 0; i < allLines.Length; i++)
            {
                if (double.TryParse(allLines[i], out double num))
                {
                    numbers[i] = Math.Round(num, 3);
                }
                else
                {
                    numbers[i] = 0;
                }
            }
            numbers = numbers.Where(x => Math.Abs(x - Math.Round(x)) < 0.0001).ToArray();

            return numbers;
        }
    }
}
