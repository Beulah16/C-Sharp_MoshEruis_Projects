using System;
using System.Collections.Generic;
namespace Mosh
{
    class UniqueNum
    {
        static void Main(string[]args)
        {
            /*Write a program and ask the user to continuously enter a number 
            ...or type "Quit" to exit. 
            The list of numbers may include duplicates. 
            Display the unique numbers that the user has entered.*/
              var numbers = new List<int>();
              while(true)
              {
                Console.Write("Enter a number or type \"Quit\" to exit: ");
                var input = Console.ReadLine();
                if(input.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    numbers.Add(Convert.ToInt32(input));
                }
              }
              var hashset = new HashSet<int>(numbers);
              Console.WriteLine("Unique numbers entered: {0}", string.Join(',', hashset));
        } 
    }
}
