using System;
namespace Mosh
{
    class Factorial
    {
        static void Main(string[]args)
        {
            /*Write a program and ask the user to enter a number. 
              Compute the factorial of the number and print it on the console.*/
             var factorial = 1;
             Console.Write("Enter a number: ");
             var num = Convert.ToInt32(Console.ReadLine());
             for (var i = num; i >0; i--)
             {
                factorial *= i;
             }
             Console.WriteLine("{0}! = {1}", num, factorial);
        }
    }
}