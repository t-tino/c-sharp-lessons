class Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Starting multithreading example...");

                // Create and start a new thread
                Thread thread = new Thread(DoWork);
                thread.Start();

                // Wait for the thread to complete
                thread.Join();

                Console.WriteLine("Multithreading example completed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the multithreading example.");
            }
        }

        static void DoWork()
        {
            Console.WriteLine("Thread is doing work...");
            Thread.Sleep(2000); // Simulate work by sleeping for 2 seconds
            Console.WriteLine("Work done in the thread.");
        }
    }
}