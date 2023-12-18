using System;

namespace _18._12
{
    class Program
    {
        static void Main(string[] args)
        {
            third();
        }
        static void first()
        {
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            double mid = 0;
            double max = 0;
            for (int i = 0; i < n; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                mass[i] = input;
                max += input;
            }
            mid = max / mass.Length;
            Console.WriteLine(mid);
        }

        static void second()
        {
            int num = 0;
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            int num100 = 0;
            for (int i = 0; i < n; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                mass[i] = input;
                if (mass[i] < 100 && mass[i] > -100)
                {
                    num100 += 1;
                }
            }
            int[] loc_mass = new int[num100];
            for (int j = 0; j < mass.Length; j++)
            {
                if (mass[j] < 100 && mass[j] > -100)
                {
                    loc_mass[num] = mass[j];
                    num += 1;
                }
            }
            for (int i = 0; i < loc_mass.Length; i++)
            {
                Console.WriteLine(loc_mass[i]);
            }
        }
        static void third()
        {
            int num = 0;
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            for (int i = 0; i<n; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                mass[i] = input;
            }
            int[] fin_mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                num = i;
                for (int j = i; j < n; j++)
                {

                    if (mass[j] == mass[i])
                    {
                       break;
                    }
                    else
                    {
                        continue;
                    }
                    //Console.WriteLine(mass[i]);
                }
                Console.WriteLine(mass[i]);
            }
        }
    }    
}
    
