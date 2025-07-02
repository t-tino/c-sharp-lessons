class RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int num = random.Next(1, 101);
            double num = random.NextDouble();

            Console.WriteLine("Random number between 1 and 100: " + num);
        }
    }
}