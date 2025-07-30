using System;

namespace DOTNET
{
    internal class _23_7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int n) && n > 0)
            {
                int rows = n + 1;
                int cols = 3;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (i == 0 || i == rows - 1)
                        {
                            Console.Write(n + " ");
                        }
                        else
                        {
                            if (j == 0 || j == cols - 1)
                            {
                                Console.Write(n + " ");
                            }
                            else
                            {
                                Console.Write(i + " ");
                            }
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a positive integer.");
            }

            Console.ReadKey();
        }
    }
}
