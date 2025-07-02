class Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Creating a generic list of integers:");
                var intList = new GenericList<int>();
                intList.Add(1);
                intList.Add(2);
                intList.Add(3);

                Console.WriteLine("Items in the integer list:");
                foreach (var item in intList.GetItems())
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Creating a generic list of strings:");
                var stringList = new GenericList<string>();
                stringList.Add("Hello");
                stringList.Add("World");

                Console.WriteLine("Items in the string list:");
                foreach (var item in stringList.GetItems())
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the generics example.");
            }
        }

        class GenericList<Thing>
        {
            private List<Thing> items = new List<Thing>();

            public void Add(Thing item)
            {
                items.Add(item);
            }

            public IEnumerable<Thing> GetItems()
            {
                return items;
            }
        }
    }
}