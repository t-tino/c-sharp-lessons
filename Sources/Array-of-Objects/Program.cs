class ArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create an array of objects
                object[] objects = new object[3];
                objects[0] = "Hello, World!";
                objects[1] = 42;
                objects[2] = 3.14;

                // Iterate through the array and display each object
                Console.WriteLine("Iterating through the array of objects:");
                foreach (var obj in objects)
                {
                    Console.WriteLine(obj);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the array of objects example.");
            }
        }
    }
}