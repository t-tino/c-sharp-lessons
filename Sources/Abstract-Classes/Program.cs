class AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Creating an instance of the derived class:");
                DerivedClass derivedObj = new DerivedClass();
                derivedObj.DisplayMessage();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the abstract class example.");
            }
        }
    }

    abstract class BaseClass
    {
        public abstract void DisplayMessage();
    }

    class DerivedClass : BaseClass
    {
        public override void DisplayMessage()
        {
            Console.WriteLine("Hello from the Derived Class that inherits from an Abstract Class!");
        }
    }
}