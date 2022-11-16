using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 7, 3, 4 };

            int k = 6;
            int c = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (k == array[j] + array[i])
                    {
                        Console.WriteLine("[{0} , {1}]", i, j);
                        c++;
                    }
                }
            }
            if (c == 0)
                Console.WriteLine("There are no elements  which sum is k");

            Console.ReadKey();
        }
    }
}
