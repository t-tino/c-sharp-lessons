// ||
// &&

class LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Do you have a driver's license? (yes/no):");
                string hasLicense = Console.ReadLine().ToLower();

                if (age >= 18 && hasLicense == "yes")
                {
                    Console.WriteLine("You are eligible to drive.");
                }
                else if (age < 18 && hasLicense == "yes")
                {
                    Console.WriteLine("You are too young to drive, but you have a license.");
                }
                else
                {
                    Console.WriteLine("You are either too young or do not have a driver's license.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number for age.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the driving eligibility program.");
            }
        }
    }
}