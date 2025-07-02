class Switches
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a day of the week (1-7):");
                int day = Convert.ToInt32(Console.ReadLine());

                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid day. Please enter a number between 1 and 7.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the day.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the day of the week program.");
            }
        }
    }
}