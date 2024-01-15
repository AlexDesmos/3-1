using System;

namespace _3_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 'true' if you want to make array by yourself, 'false' if random:");
            bool person = bool.Parse(Console.ReadLine());
            Console.WriteLine("Write number of columns of your array:");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Write width of your array:");
            int width = int.Parse(Console.ReadLine());
            Two_dimensional two_Dimensional = new Two_dimensional(person, length, width);
        }
    }
    class Two_dimensional
    {
        Random rnd = new Random();
        public Two_dimensional(bool person, int length, int width)
        {
            if (person)
                UserFill(length, width);
            else
                RndFill(length, width);
        }
        void UserFill(int length, int width)
        {
            int array_sum = 0;
            int[,] array = new int[length, width];
            for (int i = 0; i<length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.WriteLine($"X: {j} Y: {i}");
                    int input = int.Parse(Console.ReadLine());
                    array[i, j] = input;
                    array_sum += input;
                }
            }
            Console.WriteLine(array_sum / (length * width));
        }
        void RndFill(int length, int width)
        {
            int array_sum = 0;
            int[,] array = new int[length, width];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    
                    array[i, j] = rnd.Next();
                    array_sum += array[i,j];
                }
            }
            Console.WriteLine(array_sum / (length * width));
        }
        static void second(int[,] array)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.WriteLine(array[i, j] + "\t");
                }
            }
            for (int i = array.GetLength(1); i>0 ; i--)
            {
                for (int j = array.GetLength(0); j > 0;j--)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(array)
                    }
                }
            }
        }
    }
}
