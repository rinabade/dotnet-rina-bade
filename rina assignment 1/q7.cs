// Write a C# program that determines a student’s grade according to new SLC grading
// system. The program will read three types of scores(first-term score, mid-term score,
// and final score) and determine the grade based on the following rules:

using System;

namespace HelloWorldApplication
{

    public class q7
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Grades of each term || Should be interms of percentage");

            Int64 t1 = Convert.ToInt64(Console.ReadLine());
            Int64 t2 = Convert.ToInt64(Console.ReadLine());
            Int64 t3 = Convert.ToInt64(Console.ReadLine());

            Int64 result = (t1+t2+t3)/3;
            
            if(result>=90 && result<= 100){
                Console.WriteLine("Grade A");
            }
            else if(result>=70 && result<90){
                Console.WriteLine("Grade B");
            }
            else if(result>=50 && result<70){
                Console.WriteLine("Grade c");
            }
            else if(result>=35 && result<50){
                Console.WriteLine("Grade E");
            }
            else if(result>=0 && result<35){
                Console.WriteLine("Grade F");
            }
            else {
                Console.WriteLine("Invalid Score");
            }

            Console.ReadKey();
        }
    }
}