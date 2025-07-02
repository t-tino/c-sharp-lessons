class AutoImpementedProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Creating an instance of the Person class with auto-implemented properties:");
                var person = new Person
                {
                    Name = "Jane Doe",
                    Age = 25
                };

                Console.WriteLine($"Person Name: {person.Name}, Age: {person.Age}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the auto-implemented properties example.");
            }
        }

        class Person
        {
            // Auto-implemented property for Name
            public string Name { get; set; }

            // Auto-implemented property for Age
            public int Age { get; set; }
        }
    }
}