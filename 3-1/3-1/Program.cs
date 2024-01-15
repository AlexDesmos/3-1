using System;

namespace _3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 'true' if you want to make array by yourself, 'false' if random:");
            bool person = bool.Parse(Console.ReadLine());
            Console.WriteLine("Write length of your array:");
            int length = int.Parse(Console.ReadLine());
            One_dimensional one_dimensional = new One_dimensional(person, length);
        }
    }
    public class One_dimensional
    {
        Random rnd = new Random();

        public One_dimensional(bool person, int length)
        {
            if (person)
                userFill(length);
            else
                rndFill(length);
        }
        void userFill(int length)
        {
            int[] array = new int[length];
            int array_sum = 0;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Write an element:");
                array[i] = int.Parse(Console.ReadLine());
                array_sum += array[i];
            }
            Console.WriteLine(array_sum / length);
            second(array, length);
        }
        void rndFill(int length)
        {
            int array_sum = 0;
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next();
                array_sum += array[i];

            }
            Console.WriteLine(array_sum / length);
            second(array, length);
            third(array);
        }
        static void second(int[] array, int length)
        {
            int[] array2 = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 100 | array[i] > -100)
                {
                    array2[i] = array[i];
                    Console.WriteLine(array2[i]);
                }
            }
        }
        static void third(int[] array)
        {
            int p = 0;
            int m = 0;
            int[] array2 = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array2[j])
                    {
                        p++;
                    }

                }
                if (p < 1)
                {
                    array2[m] = array[i];
                    m++;
                }
                p = 0;
            }
            int[] array3 = new int[m];
            for (int f = 0; f < m; f++)
            {
                array3[f] = array2[f];
            }
            for (int h = 0; h < m; h++)
            {
                Console.WriteLine(array3[h]);
            }
        }
    }
}
