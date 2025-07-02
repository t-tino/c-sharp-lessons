class Static
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Accessing static members of the Static class:");
                Console.WriteLine($"Static Number: {StaticClass.StaticNumber}");
                Console.WriteLine($"Static Message: {StaticClass.StaticMessage}");

                StaticClass.DisplayMessage();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the static class example.");
            }
        }
        
        static class StaticClass
        {
            public static int StaticNumber { get; set; } = 42;
            public static string StaticMessage { get; set; } = "Hello from the static class!";

            public static void DisplayMessage()
            {
                Console.WriteLine(StaticMessage);
            }
        }
    }
}