﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
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
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.WriteLine($"X: {j} Y: {i}");
                    int input = int.Parse(Console.ReadLine());
                    array[i, j] = input;
                    array_sum += input;
                }
            }
            Console.WriteLine("Mid num of your array:");
            Console.WriteLine(array_sum / (length * width));
            second(array);
        }
        void RndFill(int length, int width)
        {
            int array_sum = 0;
            int[,] array = new int[length, width];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {

                    array[i, j] = rnd.Next(-100, 100);
                    array_sum += array[i, j];
                }
            }
            Console.WriteLine("Mid num of your array:");
            Console.WriteLine(array_sum / (length * width));
            second(array);
        }
        static void second(int[,] array)
        {
            Console.WriteLine("Second:");
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.WriteLine(array[i, j] + "\t");
                }
            }
            for (int i = array.GetLength(1); i > 0; i--)
            {
                for (int j = array.GetLength(0); j > 0; j--)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(array[i, j] + "\t");
                    }
                }
            }
        }
    }
}
