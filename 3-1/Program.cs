using System;

namespace _3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 'true' if you want to make array by yourself, 'false' if random:");
            bool person = bool.Parse(Console.ReadLine());
            Console.WriteLine("Write type of the array:");
            string input = Console.ReadLine();
            if (input == "One_dimensional")
            {
                Console.WriteLine("Write length of your array:");
                int length = int.Parse(Console.ReadLine());
                One_dimensional one_dimensional = new One_dimensional(person, length);
            }
            else if (input == "Two_dimensional")
            {
                Console.WriteLine("Write length of your array:");
                int length = int.Parse(Console.ReadLine());
                Console.WriteLine("Write width of your array:");
                int width = int.Parse(Console.ReadLine());

                Two_dimensional two_dimensional = new Two_dimensional(person, length, width);
            }
            else if(input== "Step_dimensional")
            {
                Console.WriteLine("Write width of your array:");
                int width = int.Parse(Console.ReadLine());
                Step_dimensional step_dimensional = new Step_dimensional(person, width);
            }
            
        }
    }
    
}
