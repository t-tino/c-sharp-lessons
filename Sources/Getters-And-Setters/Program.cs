class GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Creating an instance of the Person class:");
                var person = new Person();
                person.Name = "John Doe";
                person.Age = 30;

                Console.WriteLine($"Person Name: {person.Name}, Age: {person.Age}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the getters and setters example.");
            }
        }

        class Person
        {
            private string name;
            private int age;

            // Getter and Setter for Name
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            // Getter and Setter for Age
            public int Age
            {
                get { return age; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Age cannot be negative.");
                    }
                    age = value;
                }
            }
        }
    }
}