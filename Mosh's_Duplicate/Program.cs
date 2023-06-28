using System;
namespace Mosh
{
    class Duplicate
    {
        static void Main(string[]args)
        {
            /*Write a program and ask the user to enter a few numbers separated by a hyphen. 
              If the user simply presses Enter, without supplying an input, exit immediately; 
              ...otherwise, check to see if there are duplicates. 
              If so, display "Duplicate" on the console.*/
              
           Console.Write("Enter a series of hyphen separated numbers: ");
           var nums = Console.ReadLine();
           if(String.IsNullOrWhiteSpace(nums)){return;}
           else
           {
            var newNums = nums.Split('-');
            var numbers = new int[newNums.Length];
            for(var i = 0; i < newNums.Length; i++)
            {
                numbers[i] = Convert.ToInt32(newNums[i]);
            }
            var list = new List<int>();
            foreach(var num in numbers)
            {
                if(list.Contains(num))
                {
                    System.Console.WriteLine("Duplicate!");
                    break;
                }
                list.Add(num);
            }
           }
        }
    }
}