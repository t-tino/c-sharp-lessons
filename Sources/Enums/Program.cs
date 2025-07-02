class Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Creating an instance of the enum:");
                DayOfWeek today = DayOfWeek.Wednesday;
                Console.WriteLine($"Today is: {today}");

                // Display all enum values
                Console.WriteLine("All days of the week:");
                foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
                {
                    Console.WriteLine(day);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the enums example.");
            }
        }

        // Enum definition for days of the week
        enum DayOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}