using System;
namespace Mosh
{
    class Random
    {
        static void Main(string[]args)
        {
            /*Write a program that picks a random number between 1 and 10. 
             Give the user 4 chances to guess the number. 
             If the user guesses the number, display “You won"; otherwise, display “You lost".*/
             var random = new System.Random();
             for(var i = 1; i <= 4; i++)
             {
                Console.Write("Pick a random number between 1 and 10: ");
                var num = Convert.ToInt32(Console.ReadLine());
                var guess = random.Next(1, 10);
                 if(num == guess)
                 {
                    System.Console.WriteLine("You Won!🙂");
                 }
                 else
                 {
                    System.Console.WriteLine("You lost!☹ Number: {0}", guess);
                 }
             }
        }
    }
}