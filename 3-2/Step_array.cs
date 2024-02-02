using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    class Step_array : Dad_class
    {
        Random rnd = new Random();
        private int[][] array;
        public Step_array(bool person, int width)
        {
            array = new int[width][];
            if (person)
                userFill();
            else
                rndFill();
            print();
            getmid();
        }
        public override void userFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Write length of the line:");
                int length = int.Parse(Console.ReadLine());
                array[i] = new int[length];
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine($"X: {j} Y: {i}");
                    int num = int.Parse(Console.ReadLine());
                    array[i][j] = num;
                }
            }
        }
        public override void rndFill()
        {
            for (int i = 0; i < array.Length; i++)
            {

                array[i] = new int[rnd.Next(1, 5)];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rnd.Next(-100, 100);
                }
            }
        }
        public override void print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {

                    Console.Write(array[i][j] + "\t");
                }
            }
        }
        public override void getmid()
        {
            int mid_num = 0;
            int array_count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array_count += 1;
                    mid_num += array[i][j];
                }
            }
            Console.WriteLine($"midnum of the array: {mid_num / array_count}");
        }
    } 
}
