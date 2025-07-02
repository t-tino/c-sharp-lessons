class Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the number of elements in the array:");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] numbers = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"Please enter element {i + 1}:");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("You entered the following numbers:");
                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }
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
                Console.WriteLine("Thank you for using the array input program.");
            }
        }
    }
}