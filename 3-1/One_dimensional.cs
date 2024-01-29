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
        int[] array;

        public One_dimensional(bool person, int length, bool rec)
        {
            array = new int[length];
            if (rec)
                recreation();
            if (person)
                userFill(length);
            else
                rndFill(length);
            
        }
        public void userFill(int length)
        {
            
            
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Write an element:");
                array[i] = int.Parse(Console.ReadLine());
                
            }
            
            
        }
        public void rndFill(int length)
        {
            
            
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(-100, 100);
                

            }
            
            
        }
        public void second(int length)
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
        public void third()
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
        public void getmid()
        {
            int array_sum = 0;
            for (int i = 0; i < array.Length; i++)
                array_sum += array[i];
            Console.WriteLine("Mid num of the array:");
            Console.WriteLine(array_sum / array.Length);
        }
        public void recreation()
        {
            Console.WriteLine("Write length of your array:");
            int length = int.Parse(Console.ReadLine());
            array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Write an element:");
                array[i] = int.Parse(Console.ReadLine());

            }
        }
    }
}
