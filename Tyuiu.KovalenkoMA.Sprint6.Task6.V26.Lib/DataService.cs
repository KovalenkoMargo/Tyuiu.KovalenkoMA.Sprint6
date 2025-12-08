using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KovalenkoMA.Sprint6.Task6.V26.Lib
{
    public class DataService : ISprint6Task6V26
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    if (words.Length > 0)
                    {
                        string lastWord = words.Last();
                        result += lastWord + " ";
                    }
                }
            }
            return result.Trim(); 
        }
    }
}
