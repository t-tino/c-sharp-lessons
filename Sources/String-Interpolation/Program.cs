class StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your name:");
                string name = Console.ReadLine();

                Console.WriteLine("Please enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());

                // Using string interpolation to format the output
                Console.WriteLine($"Hello, {name}! You are {age} years old.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number for age.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the string interpolation example.");
            }
        }
    }
}