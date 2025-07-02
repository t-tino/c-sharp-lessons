class ObjectAsArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Creating an instance of the Person class:");
                Person person = new Person("John Doe", 30);
                person.DisplayInfo();

                Console.WriteLine("Passing the Person object to the DisplayPersonInfo method:");
                DisplayPersonInfo(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the object as arguments example.");
            }
        }

        static void DisplayPersonInfo(Person person)
        {
            Console.WriteLine($"Person Name: {person.Name}, Age: {person.Age}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
}