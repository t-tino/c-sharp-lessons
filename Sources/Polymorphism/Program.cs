class Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Creating an instance of the base class:");
                Animal animal = new Animal();
                animal.MakeSound();

                Console.WriteLine("Creating an instance of the derived class:");
                Dog dog = new Dog();
                dog.MakeSound();

                Console.WriteLine("Creating an instance of another derived class:");
                Cat cat = new Cat();
                cat.MakeSound();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the polymorphism example.");
            }
        }

        class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Some generic animal sound");
            }
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Woof! Woof!");
            }
        }

        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow! Meow!");
            }
        }
    }
}