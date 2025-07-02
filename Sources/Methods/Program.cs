class Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number to calculate its square:");
                int number = Convert.ToInt32(Console.ReadLine());
                int result = CalculateSquare(number);
                Console.WriteLine($"The square of {number} is {result}.");
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
                Console.WriteLine("Thank you for using the square calculation program.");
            }
        }

        static int CalculateSquare(int num)
        {
            return num * num;
        }
    }
}