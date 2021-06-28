using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] arrayTwo = new int[] { 5, 7, 3 };

            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < arrayTwo.Length; j++)
                {
                    if (array[i] == arrayTwo[j])
                    {
                        int temp = arrayTwo[index];
                        arrayTwo[index] = arrayTwo[j];
                        arrayTwo[j] = temp;

                        index++;
                    }
                }
            }

            foreach (int j in arrayTwo)
            {
                Console.WriteLine(j);
            }

        }
    }
}
