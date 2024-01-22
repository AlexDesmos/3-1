using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    class Step_dimensional
    {
        Random rnd = new Random();
        public Step_dimensional(bool person, int width)
        {
            if (person)
                UserFill(width);
            else
                RndFill(width);
        }
        void UserFill(int width)
        {
            int line_num = 0;
            int array_num = 0;
            int sum_num = 0;
            int[][] array = new int[width][];
            for (int i = 0; i < width; i++)
            {
                Console.WriteLine("Write length of the line:");
                int length = int.Parse(Console.ReadLine());
                for (int j = 0; j < length; j++)
                {
                    array[i] = new int[length];
                    Console.WriteLine("Write num:");
                    int num = int.Parse(Console.ReadLine());
                    array[i][j] = num;
                    sum_num += num;
                    array_num += 1;
                    line_num += array[i][j];
                    Console.WriteLine($"mid num of the line {i+1}:");
                    Console.WriteLine(line_num / array[i].Length);
                }
                line_num = 0;
            }
            Console.WriteLine("mid num of the array:");
            Console.WriteLine(sum_num / array_num);
            trird(array, width);
        }
        void RndFill(int width)
        {
            int line_num = 0;
            int array_num = 0;
            int sum_num = 0;
            int[][] array = new int[width][];
            for (int i = 0; i < width; i++)
            {
                Console.WriteLine("Write length of the line:");
                int length = int.Parse(Console.ReadLine());
                for (int j = 0; j < length; j++)
                {
                    array[i] = new int[rnd.Next(0, 5)];
                    array[i][j] = rnd.Next(-100, 100);
                    sum_num += array[i][j];
                    array_num += 1;
                    line_num += array[i][j];
                    Console.WriteLine($"mid num of the line {i+1}:");
                    Console.WriteLine(line_num / array[i].Length);
                }
                line_num = 0;
            }
            Console.WriteLine("mid num of the array:");
            Console.WriteLine(sum_num / array_num);
            trird(array, width);
        }
        static void trird(int[][] array, int width)
        {
            Console.WriteLine("new array:");
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < array[j].Length; j++)
                {


                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                        Console.WriteLine(array[i][j] + "\t");
                    }
                }
            }
        }
    }
}
