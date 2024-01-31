using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    sealed class One_array : Dad_class
    {
        Random rnd = new Random();
        private int[] array;
        

        public One_array(bool person, int length)
        {
            array = new int[length];
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
                Console.WriteLine("Write an element:");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        public override void rndFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
        }

        public override void getmid()
        {
            int sum_num = 0;
            for (int i = 0; i < array.Length; i++)
                sum_num += array[i];
            Console.WriteLine($"Middle num of array is {sum_num / array.Length}.");
        }
        public override void print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
        }
    }

}
