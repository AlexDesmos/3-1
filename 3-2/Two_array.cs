using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    class Two_array : Dad_class
    {
        Random rnd = new Random();
        private int[,] array;
        public Two_array(bool person, int length, int width)
        {
            array = new int[length, width];
            if (person)
                userFill();
            else
                rndFill();
            print();
            getmid();
        }
        public override void userFill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"X: {j} Y: {i}");
                    int input = int.Parse(Console.ReadLine());
                    array[i, j] = input;
                }
            }
        }
        public override void rndFill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    array[i, j] = rnd.Next(-100, 100); 
                }
            }
        }
        public override void print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write(array[i, j] + "\t");
                }
            }
        }
        public override void getmid()
        {
            int mid_num = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    mid_num += array[i, j];
                }
            }
            Console.WriteLine($"midnum of the array: {mid_num / array.GetLength(0) * array.GetLength(1)}");
        }
    }
}
