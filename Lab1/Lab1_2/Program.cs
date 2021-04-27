using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[9];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            arr[i] = rand.Next(0, 9);

            int perem;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        perem = arr[i];
                        arr[i] = arr[j];
                        arr[j] = perem;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
