class ToStringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("John", "Doe", 30);
            Console.WriteLine(person.ToString());
        }

        class Person
        {
            public string FirstName { get; }
            public string LastName { get; }
            public int Age { get; }

            public Person(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }

            public override string ToString()
            {
                return $"{FirstName} {LastName}, Age: {Age}";
            }
        }
    }
}