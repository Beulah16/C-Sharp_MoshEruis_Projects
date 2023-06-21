using System;
namespace Mosh
{
    class Validation
    {
        static void Main(string[]args)
        {
            /*Write a program and ask the user to enter a number. 
             *The number should be between 1 to 10. 
             *If the user enters a valid number, display "Valid" on the console. 
             *Otherwise, display "Invalid".*/
             Console.Write("Enter a number : ");
             var num = Convert.ToInt32(Console.ReadLine());
             if (num > 0 && num <= 10)
             {
                Console.WriteLine("Valid");
             }
             else
             {
                Console.WriteLine("Invalid");
             }
        }
    }
}