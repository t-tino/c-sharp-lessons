class ReturnKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number to check if it's even or odd:");
                int number = Convert.ToInt32(Console.ReadLine());
                string result = CheckEvenOdd(number);
                Console.WriteLine(result);
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
                Console.WriteLine("Thank you for using the even/odd checker program.");
            }
        }

        static string CheckEvenOdd(int num)
        {
            if (num % 2 == 0)
            {
                return $"{num} is even.";
            }
            else
            {
                return $"{num} is odd.";
            }
        }
    }
}