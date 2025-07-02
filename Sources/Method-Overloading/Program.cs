class MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number to calculate its square:");
                int number = Convert.ToInt32(Console.ReadLine());
                int squareResult = Calculate(number);
                Console.WriteLine($"The square of {number} is {squareResult}.");

                Console.WriteLine("Please enter two numbers to calculate their sum:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                int sumResult = Calculate(num1, num2);
                Console.WriteLine($"The sum of {num1} and {num2} is {sumResult}.");
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
                Console.WriteLine("Thank you for using the method overloading example.");
            }
        }

        static int Calculate(int num)
        {
            return num * num;
        }

        static int Calculate(int a, int b)
        {
            return a + b;
        }
    }
}