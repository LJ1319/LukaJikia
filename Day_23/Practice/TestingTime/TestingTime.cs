namespace TestingTime
{
    internal class TestingTime
    {
        public List<string[]> text = new List<string[]>();

        public List<string> correctAnswers = new List<string>();

        public void startTest(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                text.Add(line.Split('|', '\n'));
            }

            foreach (var line in text)
            {
                foreach (var word in line)
                {
                    if (word.Contains('*'))
                    {
                        correctAnswers.Add(word.Replace('*', ' '));
                    }
                }
            }
        }

        public void addTest(string filePath, List<string> userContent)
        {
            File.AppendAllLines(filePath, userContent);
        }
    }
}
