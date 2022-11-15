// 8. Write C# code to declare one integer variable, one float variable, and one string
// variable and assign 10, 12.5, and "50" to them respectively.
// a. Display their values on the screen.
// b. Add their values in floating point value and display the sum on the screen.
// c. Concatenate their values and display the output on the screen.

using System;

namespace HelloWorldApplication
{

    public class q8
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Grades of each term || Should be interms of percentage");
            
            int a = 10;
            float b = 12.55F;
            string c = "50";

            
            //8a
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            // 8b
            float num1 = Convert.ToSingle(a);
            float num2 = Convert.ToSingle(c);
            
            float sum = num1+b+num2;

            Console.WriteLine($"Sum = {sum}");

            //8c

            string s1 = Convert.ToString(a);
            string s2 = Convert.ToString(b);
            
            string strings = s1+s2+c;
            Console.WriteLine($"String is = {strings}");
            

            Console.ReadKey();
        }
    }
}