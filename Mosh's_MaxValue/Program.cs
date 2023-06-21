using System;
namespace Mosh
{
    class MaxValue
    {
        static void Main(string[]args)
        {
            /*Write a program which takes two numbers from the console 
             *and displays the maximum of the two*/
             Console.Write("Enter two numbers; \nnum1 = ");
             var num1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("num2 = ");
             var num2 = Convert.ToInt32(Console.ReadLine());
             if (num1 > num2)
             {
                Console.WriteLine("{0} is the maximum", num1);
             }
             else
             {
                Console.WriteLine("{0} is the maximum", num2);
             }
        }
    }
}