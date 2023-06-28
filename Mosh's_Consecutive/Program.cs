using System;
namespace Mosh
{
    class Consecutive
    {
        static void Main(string[]args)
        {
            /* Write a program and ask the user to enter a few numbers 
              ...separated by a hyphen. 
              Work out if the numbers are consecutive.*/
              
           Console.Write("Enter a series of hyphen separated numbers: ");
           var nums = Console.ReadLine();
           var newNums = nums.Split('-');
           var numbers = new int[newNums.Length];
           for(var i = 0; i < newNums.Length; i++)
           {
            numbers[i] = Convert.ToInt32(newNums[i]);
           }
           var num = numbers[0];
           for(var j = 1; j <= numbers.Length-1; j++)
           {
                if(num + 1 == numbers[j])
                {
                    num++;
                }
                else if (num - 1 == numbers[j])
                {
                    num--;
                }
                else
                {
                    System.Console.WriteLine("Not consecutive");
                    break;
                }
           }
           if(num == numbers.Last())
           {
            Console.WriteLine("Consecutive");
           }
        }
    }
}