class Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            string name = "John Doe";
            double height = 5.9;
            bool isEmployed = true;
            char initial = 'J';
            decimal salary = 50000.75m;
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Is Employed: " + isEmployed);
            Console.WriteLine("Initial: " + initial);
            Console.WriteLine("Salary: " + salary);

            Console.ReadKey();
        }
    }
}