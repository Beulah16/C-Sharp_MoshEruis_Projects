using System;
namespace Mosh
{
    class MaxNum
    {
        static void Main(string[]args)
        {
            /*Write a program and ask the user to enter a series of numbers separated by comma. 
              Find the maximum of the numbers and display it on the console.*/
              
           Console.Write("Enter a series of numbers separated by comma: ");
           string series= Console.ReadLine();
           var character = series.Split(',');

           var max = Convert.ToInt32(character[0]);
            foreach(var item in character)
            {
                var num = Convert.ToInt32(item);
                if(num > max)
                max = num;
            }
            Console.WriteLine("{0} is the maximum number", max);
        }
    }
}