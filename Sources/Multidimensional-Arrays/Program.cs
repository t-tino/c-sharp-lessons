class MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Define a 2D array (matrix)
                int[,] matrix = new int[3, 3]
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                };

                // Display the elements of the matrix
                Console.WriteLine("Matrix elements:");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the multidimensional arrays example.");
            }
        }
    }
}