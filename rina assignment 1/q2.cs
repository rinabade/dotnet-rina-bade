// Write a C# program that asks the user to input three integer values and find the greatest value of the three values.

using System;

namespace HelloWorldApplication
{

    public class q2
    {
            static void Main(string[] args)
        {

            Console.WriteLine("Enter Any 3 numbers");

            Int64 a = Convert.ToInt64(Console.ReadLine());
            Int64 b = Convert.ToInt64(Console.ReadLine());

            Int64 c = Convert.ToInt64(Console.ReadLine());

            if(a>b && a>c){
                Console.WriteLine($"The Greatest is {a}");
            }
            else if(b>c && b>a){
                Console.WriteLine($"The Greatest is {b}");

            }else{
                Console.WriteLine($"The Greatest is {c}");
            }
            Console.ReadKey();
        }
    }
}