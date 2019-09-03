using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortNames
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] numbers = { 51, 0, 52, 5, -41, 45, 1 };
                int t;
                Console.WriteLine("unsorted array");
                foreach (int digit in numbers)
                    Console.Write(digit + " ");
                for (int p = 0; p <= numbers.Length - 2; p++)
                {
                    for (int i = 0; i <= numbers.Length - 2; i++)
                    {
                        if (numbers[i] > numbers[i + 1])
                        {
                            t = numbers[i + 1];
                            numbers[i + 1] = numbers[i];
                            numbers[i] = t;
                        }
                    }
                }
                Console.WriteLine("\n" + "Sorted array");
                foreach (int aa in numbers)
                    Console.Write(aa + " ");
                Console.Write("\n");

            }

        }
    }
}
