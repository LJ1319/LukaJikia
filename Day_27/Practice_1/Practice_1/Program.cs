namespace Practice_1
{
    internal class Program
    {
        static string dirPath = @"C:\Users\LJ\source\repos\LukaJikia\Day_27\Practice_1\Practice_1\Data\";
        static void Main()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            for (int i = 1; i <= 10; i++)
            {
                WriteToFile(i, cancellationToken);
            }

            Console.WriteLine("Press 'x' to cancel");
            if (Console.ReadKey(true).KeyChar == 'x')
            {
                cancellationTokenSource.Cancel();
                Console.WriteLine("'x' was pressed");
                Console.WriteLine("Press any key to exit.");
            }

            Console.ReadKey();
            cancellationTokenSource.Dispose();
        }

        static void WriteToFile(int num, CancellationToken cancellationToken)
        {
            Task.Run(() =>
            {
                var file = File.Create(dirPath + $"{num}.txt");
                using (StreamWriter sw = new StreamWriter(file))
                {
                    sw.AutoFlush = true;
                    while (!cancellationToken.IsCancellationRequested)
                    {
                        sw.WriteLine($"task{num}");
                        Task.Delay(num * 100).Wait();
                        Console.WriteLine($"task {num} wrote new line");
                    }
                }
            }, cancellationToken);
        }
    }
}