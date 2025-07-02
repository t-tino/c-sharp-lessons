class WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number (0 to exit):");
                int number;
                while (true)
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number == 0)
                    {
                        Console.WriteLine("Exiting the loop.");
                        break;
                    }
                    Console.WriteLine($"You entered: {number}");
                }

                do
                {
                    Console.WriteLine("Please enter another number (0 to exit):");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number == 0)
                    {
                        Console.WriteLine("Exiting the do-while loop.");
                        break;
                    }
                    Console.WriteLine($"You entered: {number}");
                } while (true);
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
                Console.WriteLine("Thank you for using the number input program.");
            }
        }
    }
}