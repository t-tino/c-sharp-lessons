class StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "John Doe";

            // Convert to uppercase
            string upperCaseName = fullName.ToUpper();

            // Convert to lowercase
            string lowerCaseName = fullName.ToLower();

            // Check if the string contains a substring
            bool containsJohn = fullName.Contains("John");

            // Find the index of a substring
            int indexOfDoe = fullName.IndexOf("Doe");

            // Split the string into an array
            string[] nameParts = fullName.Split(' ');

            // Replace a substring with another substring
            string replacedName = fullName.Replace("Doe", "Smith");

            // Trim whitespace from the start and end of the string
            string trimmedName = fullName.Trim();

            // Check if the string starts with a specific substring
            bool startsWithJohn = fullName.StartsWith("John");

            // Check if the string ends with a specific substring
            bool endsWithDoe = fullName.EndsWith("Doe");

            // Get the length of the string
            int nameLength = fullName.Length;

            // Print the results
            Console.WriteLine("Original Name: " + fullName);

            Console.WriteLine("Uppercase: " + upperCaseName);
            Console.WriteLine("Lowercase: " + lowerCaseName);
            Console.WriteLine("Contains 'John': " + containsJohn);
            Console.WriteLine("Index of 'Doe': " + indexOfDoe);
            Console.WriteLine("Name Parts: " + string.Join(", ", nameParts));
            Console.WriteLine("Replaced Name: " + replacedName);
            Console.WriteLine("Trimmed Name: " + trimmedName);
            Console.WriteLine("Starts with 'John': " + startsWithJohn);
            Console.WriteLine("Ends with 'Doe': " + endsWithDoe);
            Console.WriteLine("Name Length: " + nameLength);
        }
    }
}