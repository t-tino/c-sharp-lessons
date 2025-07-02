class Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Creating a new instance of the Person class.");
                Person person = new Person("John", 30);
                person.DisplayInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the constructors example.");
            }
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            // Constructor with parameters
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            // Method to display person information
            public void DisplayInfo()
            {
                Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
            }
        }
    }
}