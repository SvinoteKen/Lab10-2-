using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                if (random.NextDouble() < 0.14)
                {
                    arr[i] = 1;
                }
                else if (random.NextDouble() < 0.28 && random.NextDouble() > 0.14)
                {
                    arr[i] = 2;
                }
                else if (random.NextDouble() < 0.42 && random.NextDouble() > 0.28)
                {
                    arr[i] = 5;
                }
                else if (random.NextDouble() < 0.56 && random.NextDouble() > 0.42)
                {
                    arr[i] = 10;
                }
                else if (random.NextDouble() < 0.70 && random.NextDouble() > 0.56)
                {
                    arr[i] = 20;
                }
                else if (random.NextDouble() < 0.84 && random.NextDouble() > 0.70)
                {
                    arr[i] = 50;
                }
                else 
                {
                    arr[i] = 100;
                }
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив:");
            CountingSort(arr, 0, arr.Length - 1);
            foreach (int money in arr)
            {
                Console.Write(money + " ");
            }
        }
        public static void CountingSort(int[] arr, int left, int right)
        {
            int min = 0, max = 0;
            for (int i = left; i <= right; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            int bn = max - min + 1;
            int[] buckets = new int[bn];
            for (int i = left; i <= right; i++)
            {
                buckets[arr[i] - min]++;
            }
            int index = 0;
            for (int i = min; i <= max; i++)
            {
                for (int j = 0; j < buckets[i - min]; j++)
                {
                    arr[index++] = i;
                }
            }
        }
    }
}
