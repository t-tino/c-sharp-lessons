class Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Creating an instance of the class that implements the interface:");
                IExample example = new ExampleClass();
                example.DisplayMessage();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the interfaces example.");
            }
        }

        interface IExample
        {
            void DisplayMessage();
        }

        class ExampleClass : IExample
        {
            public void DisplayMessage()
            {
                Console.WriteLine("Hello from the Example Class implementing the IExample interface!");
            }
        }
    }
}