namespace CShapeFundermental
{
    class Program
    {
        private static bool CheckPrimeNumber(int number)
        {
            if (number == 1)
            {
                return false;
            }

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static async void PrintPrimeNumber(int start, int end)
        {
            await Task.Run(() =>
            {
                for (int i = start; i <= end; i++)
                {
                    if (CheckPrimeNumber(i))
                    {
                        Console.WriteLine(i);
                        Task.Delay(100).Wait();
                    }
                }
            });
        }

        static void Main(string[] args)
        {
            PrintPrimeNumber(1, 1000);
            Console.ReadKey();
        }
    }
}