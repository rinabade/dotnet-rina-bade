//6. Write C# code to print the following pattern:

using System;

namespace HelloWorldApplication
{

    public class q6
    {
        static void Main(string[] args)
        {

            for (int k = 1; k <= 7; k++)
            {
                for (int i = 1; i <= k; i++){
                    Console.Write(i);
                }
                for (int j = 7; j > k; j--){
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }

        }
    }
}