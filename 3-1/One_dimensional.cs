using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    class One_dimensional
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
            Console.WriteLine("Mid num of the array:");
            Console.WriteLine(array_sum / length);
            second(array, length);
            third(array);
        }
        void rndFill(int length)
        {
            int array_sum = 0;
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(-100, 100);
                array_sum += array[i];

            }
            Console.WriteLine("Mid num of the array:");
            Console.WriteLine(array_sum / length);
            second(array, length);
            third(array);
        }
        static void second(int[] array, int length)
        {
            Console.WriteLine("Second:");
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
            Console.WriteLine("Trird:");
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
