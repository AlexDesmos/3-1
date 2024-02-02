using System;

namespace _3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 'true' if you want to make array by yourself, 'false' if randomly:");
            bool person = bool.Parse(Console.ReadLine());
            Console.WriteLine("Write type of the array:");
            string input = Console.ReadLine();
            if (input == "one_array")
            {
                Console.WriteLine("Write length of your array:");
                int length = int.Parse(Console.ReadLine());
                One_array one_array = new One_array(person, length);
            }
            else if (input == "two_array")
            {
                Console.WriteLine("Write length of your array:");
                int length = int.Parse(Console.ReadLine());
                Console.WriteLine("Write width of your array:");
                int width = int.Parse(Console.ReadLine());

                Two_array two_array = new Two_array(person, length, width);

            }
            else if (input == "Step_dimensional")
            {
                Console.WriteLine("Write width of your array:");
                int width = int.Parse(Console.ReadLine());


                Step_array step_array = new Step_array(person, width);

            }

        }
    }
}
