class NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the number of rows for the multiplication table:");
                int rows = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the number of columns for the multiplication table:");
                int columns = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= columns; j++)
                    {
                        Console.Write($"{i * j}\t");
                    }
                    Console.WriteLine();
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
                Console.WriteLine("Thank you for using the multiplication table program.");
            }
        }
    }
}