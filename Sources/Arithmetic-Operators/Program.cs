class ArithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int friends = 5;

            // friends = friends + 1; // Increment
            // friends += 1; // Increment
            // friends++; // Increment

            // friends = friends - 1; // Decrement
            // friends -= 1; // Decrement
            // friends--; // Decrement

            // friends = friends * 2; // Multiply
            // friends *= 2; // Multiply

            // friends = friends / 2; // Divide
            // friends /= 2; // Divide

            // friends = friends % 2; // Modulus
            friends %= 2; // Modulus

            Console.WriteLine(friends);
            Console.WriteLine("You dont have friends!");
            Console.WriteLine("Maybe you have a cat?");
        }
    }
}