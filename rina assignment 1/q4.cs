//6. Write a C# program that asks the user to input n integer values and find the greatest value of the n values.

using System;

namespace HelloWorldApplication
{

    public class q6
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter n");
            Int64 n = Convert.ToInt64(Console.ReadLine());
            Int64[] array=new Int64[n];
            Console.WriteLine("Enter new numbers");
            for (int i = 0; i < n; i++)
            {

                array [i] = Convert.ToInt64(Console.ReadLine());

            }

            foreach (Int64 item in array)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("Enter Your Name");

            var name = Console.ReadLine();
            Console.WriteLine($"Hey {name} !!");

            Console.ReadKey();
        }
    }
}