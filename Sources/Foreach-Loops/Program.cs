class ForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] args = { "apple", "banana", "cherry" };

            try
            {
                Console.WriteLine("Iterating through the array using foreach loop:");
                foreach (string fruit in args)
                {
                    Console.WriteLine(fruit);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the foreach loop example.");
            }
        }
    }
}