class OverloadedConstructors
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of the class using the first constructor
            var instance1 = new MyClass(10);
            instance1.DisplayValue();

            // Create an instance of the class using the second constructor
            var instance2 = new MyClass("Hello");
            instance2.DisplayValue();
        }
    }

    class MyClass
    {
        private int _intValue;
        private string _stringValue;

        // Constructor that takes an integer
        public MyClass(int value)
        {
            _intValue = value;
            _stringValue = null; // Initialize string to null
        }

        // Constructor that takes a string
        public MyClass(string value)
        {
            _intValue = 0; // Initialize int to zero
            _stringValue = value;
        }

        // Method to display the values
        public void DisplayValue()
        {
            if (_stringValue != null)
            {
                Console.WriteLine($"String Value: {_stringValue}");
            }
            else
            {
                Console.WriteLine($"Integer Value: {_intValue}");
            }
        }
    }
}