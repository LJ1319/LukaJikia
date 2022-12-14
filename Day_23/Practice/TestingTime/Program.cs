using System.Text;

namespace TestingTime
{
    internal partial class Program
    {
        public static void userTest_QuestionAnswered(object sender, QuestionAnsweredEventArgs args)
        {
            Console.WriteLine("Your answer is " + args.IsCorrect);
        }

        static void Main()
        {
            Console.WriteLine("1)Start Test\t2)Add Test");
            Console.Write("Enter your choice: ");
            int userChoice = int.Parse(Console.ReadLine());

            string dataFilePath = @"C:\Users\LJ\source\repos\LukaJikia\Day_23\Practice\TestingTime\Tests.txt";
            string logFilePath = @"C:\Users\LJ\source\repos\LukaJikia\Day_23\Practice\TestingTime\Logs.txt";

            TestingTime userTest = new TestingTime();
            userTest.QuestionAnswered += userTest_QuestionAnswered;

            string userCorrectAnswerInput;
            int userCorrectAnswersCount = 0;
            List<string> userCorrectAnswers = new List<string>();

            string userQuestion;
            string userAnswer;
            StringBuilder userContent = new StringBuilder();
            List<string> userContents = new List<string>();

            switch (userChoice)
            {
                case 1:
                    userTest.StartTest(dataFilePath);
                    int idx = 0;

                    foreach (var line in userTest.text)
                    {
                        foreach (var word in line)
                        {
                            Console.WriteLine(word.Replace('*', ' '));
                        }

                        Console.Write("Enter your answer: ");
                        userCorrectAnswerInput = Console.ReadLine();
                        userCorrectAnswers.Add(userCorrectAnswerInput);

                        Console.Write("Correct Answer: ");
                        Console.WriteLine(userTest.correctAnswers[idx]);

                        if ($"{userCorrectAnswers[idx]} " == userTest.correctAnswers[idx])
                        {
                            userCorrectAnswersCount += 1;
                            userTest.AnswerQuestion(true, logFilePath);
                        }
                        else
                        {
                            userTest.AnswerQuestion(false, logFilePath);
                        }
                        idx += 1;
                    }

                    /*for (int i = 0; i < userTest.correctAnswers.Count; i++)
                    {
                        for (int j = 0; j < userCorrectAnswers.Count; j++)
                        {
                            if (i == j & userTest.correctAnswers[i] == $"{userCorrectAnswers[j]} ")
                            {
                                userCorrectAnswersCount += 1;
                            }
                        }
                    }*/

                    Console.WriteLine($"{userCorrectAnswersCount} / {userCorrectAnswers.Count}");

                    break;
                case 2:
                    Console.WriteLine("Enter the question:");

                    try
                    {
                        userQuestion = Console.ReadLine();

                        if (!(userQuestion.Length > 0))
                        {
                            throw new Exception("Mustn't be an empty string!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }

                    userContent.Append($"{userQuestion}?|");

                    Console.WriteLine("Enter 4 answers separating Enter button,\r\nif the answer is correct select it with ‘*’ symbol at the end.");
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"Answer {i + 1}: ");

                        try
                        {
                            userAnswer = Console.ReadLine();

                            if (!(userAnswer.Length > 0))
                            {
                                throw new Exception("Mustn't be an empty string!");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            return;
                        }

                        if (i != 3)
                        {
                            userContent.Append($"{userAnswer}|");
                        }
                        else
                        {
                            userContent.Append($"{userAnswer}");
                        }
                    }

                    try
                    {
                        if (!(userContent.ToString().Contains('*')))
                        {
                            throw new Exception("Must contain '*' for a correct answer!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }

                    userContents.Add(userContent.ToString());
                    userTest.AddTest(dataFilePath, userContents);
                    break;
                default:
                    break;
            }
        }
    }
}