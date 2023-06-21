using System;
namespace Mosh
{
    class Divisible
    {
        static void Main(string[]args)
        {
            /*Write a program to count how many numbers 
             *....between 1 and 100 are divisible by 3 with no remainder. 
             *Display the count on the console.*/
             int count = 0;
             for(var i = 1; i <=100; i++)
             {
                if(i % 3 == 0)
                {
                    count += 1;
                }
             }
             
                Console.WriteLine("{0} numbers are divisible by 3", count);
        }
    }
}
