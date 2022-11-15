//Write a C# program which asks the user for two numbers and an operator to perform on them (+,-,x,/) and displays the result of that operation, as in this example:

using System;

namespace HelloWorldApplication
{

    public class q5
    {
        static void Main(string[] args)
        {

            Int16 a = Convert.ToInt16(Console.ReadLine());
            Int16 b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Operator");
            var c = Console.ReadLine();


            if (c == "+")
            {
                var res = a + b;
                Console.WriteLine(res);
            }
            else if (c == "-")
            {
                var res = a - b;
                Console.WriteLine(res);
            }
            else if (c == "*")
            {
                var res = a * b;
                Console.WriteLine(res);
            }
            else if (c == "/")
            {
                var res = a / b;
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }

            Console.ReadKey();
        }
    }
}