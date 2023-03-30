using System;

namespace ConsoleApp38

{
    class Program
    {
        static void Main(string[] args)

        {
            int[] ab = { 10, 23, 50, 20, 55 };
            Console.WriteLine("element are divisible by 10 in array is");
            for (int i = 0; i < ab.Length; i++)
            {
                if (ab[i] % 10 == 0)
                {
                    Console.Write(ab[i] + " ");
                }
            }
            Console.ReadLine();
        }
    }
}