class ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());

                // Using the conditional operator to determine if the number is even or odd
                string result = (number % 2 == 0) ? "even" : "odd";
                Console.WriteLine($"The number {number} is {result}.");
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
                Console.WriteLine("Thank you for using the conditional operator example.");
            }
        }
    }
}