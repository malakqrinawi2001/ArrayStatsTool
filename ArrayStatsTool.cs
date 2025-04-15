using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter element #{i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double average = (double)sum / numbers.Length;

            int minValue = numbers[0];
            int maxValue = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                }
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\n=== Results ===");
            Console.WriteLine("Sum of numbers: " + sum);
            Console.WriteLine("Average of numbers: " + average);
            Console.WriteLine("Smallest number: " + minValue);
            Console.WriteLine("Largest number: " + maxValue);

            Console.WriteLine("\nNumbers in ascending order:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
