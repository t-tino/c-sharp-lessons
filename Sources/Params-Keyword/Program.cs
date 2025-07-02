class ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter numbers separated by spaces:");
                string input = Console.ReadLine();
                string[] numbers = input.Split(' ');
                int[] intNumbers = Array.ConvertAll(numbers, int.Parse);

                int sum = CalculateSum(intNumbers);
                Console.WriteLine($"The sum of the entered numbers is: {sum}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the sum calculation program.");
            }
        }

        static int CalculateSum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}