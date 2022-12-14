namespace TestingTime
{
    internal class TestingTime
    {
        public List<string[]> text = new List<string[]>();

        public List<string> correctAnswers = new List<string>();

        public void StartTest(string dataFilePath)
        {
            string[] lines = File.ReadAllLines(dataFilePath);

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

        public void AnswerQuestion(bool isCorrect, string logFilePath)
        {
            QuestionAnsweredEventArgs args = new QuestionAnsweredEventArgs();
            args.IsCorrect = isCorrect;
            OnQuestionAnswered(args);

            using (StreamWriter w = File.AppendText(logFilePath))
            {
                Log(isCorrect.ToString(), w);
            }
        }

        public void Log(string logMessage, TextWriter w)
        {
            w.WriteLine(logMessage);
        }

        public void AddTest(string dataFilePath, List<string> userContent)
        {
            File.AppendAllLines(dataFilePath, userContent);
        }

        public event EventHandler<QuestionAnsweredEventArgs> QuestionAnswered;

        protected virtual void OnQuestionAnswered(QuestionAnsweredEventArgs args) 
        {
            QuestionAnswered?.Invoke(this, args);
        }
    }
}
