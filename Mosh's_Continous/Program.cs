using System;
namespace Mosh
{
    class Continous
    {
        static void Main(string[]args)
        {
            /*Write a program and continuously ask the user to enter a number 
              ...or "ok" to exit. 
              Calculate the sum of all the previously entered numbers 
              ...and display it on the console.*/
             var sum = 0;
             System.Console.WriteLine("Note: Enter \"ok\" to exit");
             while(true)
             {
                Console.Write("Enter a number: ");
                try
                {
                    var num = Convert.ToInt32(Console.ReadLine());
                    sum += num;
                }
                catch(Exception)
                {
                    break;
                }
             }
             System.Console.WriteLine("Sum of entered numbers = {0}", sum);
        }
    }
}
