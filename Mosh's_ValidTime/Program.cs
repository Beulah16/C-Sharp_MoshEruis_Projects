using System;
namespace Mosh
{
    class ValidTime
    {
        static void Main(string[]args)
        {
            /*Write a program and ask the user to enter a time value in the 24-hour time format.
             If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
             If the user doesn't provide any values, consider it as invalid time.*/
            Console.Write("Enter a time using the 24-hour time format: ");
            var time = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(time))
            {
                Console.WriteLine("Invalid Time!");
            }
            else
            {
                try
                {
                    var timespan = TimeSpan.Parse(time);
                    Console.WriteLine("Ok");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Time!");
                }
            }
        }
    }
}
