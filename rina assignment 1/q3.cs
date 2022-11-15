// Write C# code to prompt a user to input his/her first-name and then the output will be shown as an example below:

using System;

namespace HelloWorldApplication
{

    public class q3
    {
            static void Main(string[] args)
        {

            Console.WriteLine("Enter Your Name");

            var name = Console.ReadLine();
            Console.WriteLine($"Hey {name} !!");

            Console.ReadKey();
        }
    }
}