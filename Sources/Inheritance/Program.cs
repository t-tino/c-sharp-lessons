class Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Creating an instance of the base class:");
                BaseClass baseObj = new BaseClass();
                baseObj.DisplayMessage();

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
                Console.WriteLine("Thank you for using the inheritance example.");
            }
        }
    }

    class BaseClass
    {
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Hello from the Base Class!");

        }
    }

    class DerivedClass : BaseClass
    {
        public override void DisplayMessage()
        {
            Console.WriteLine("Hello from the Derived Class!");
        }
    }
}