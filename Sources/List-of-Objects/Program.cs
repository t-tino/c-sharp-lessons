class ListOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Creating a list of objects:");
                var objects = new List<object>
                {
                    "Hello, World!",
                    42,
                    3.14,
                    new DateTime(2023, 10, 1)
                };

                foreach (var obj in objects)
                {
                    Console.WriteLine($"Object: {obj}, Type: {obj.GetType()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the list of objects example.");
            }
        }
    }
}