class ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number to count up to:");
                int countTo = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= countTo; i++)
                {
                    Console.WriteLine($"Count: {i}");
                }

                Console.WriteLine("Counting completed.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the counting program.");
            }
        }
    }
}