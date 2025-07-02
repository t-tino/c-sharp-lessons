class Lists
{
    static void Main(string[] args)
    {
        // Create a list of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Add an element to the list
        numbers.Add(6);

        // Remove an element from the list
        numbers.Remove(3);

        // Display the elements in the list
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}