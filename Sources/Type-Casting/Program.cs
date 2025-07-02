class TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 123.43;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c) + 0.5;

            // ToChar
            // ToString
            // ToBoolean

            Console.WriteLine(a.GetType());
            Console.WriteLine(b);
        }
    }
}