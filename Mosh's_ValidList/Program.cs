using System;
namespace Mosh
{
    class ValidList
    {
        static void Main(string[]args)
        {
            /*Write a program and ask the user to supply a list of comma separated numbers.
              If the list is empty or includes less than 5 numbers, 
              ...display "Invalid List" and ask the user to re-try; 
              ...otherwise, display the 3 smallest numbers in the list.*/
              
           Console.Write("Enter a series of comma separated numbers: ");
           string series= Console.ReadLine();
           var character = series.Split(',');
           var numbers = new List<int>();
           for(var i = 0; i < character.Length; i++)
           {
            numbers.Add(Convert.ToInt32(character[i]));
           }
            if(numbers.Count < 5)
            {
                Console.WriteLine("Invalid List");
            }
            else
            {
                var newList = new List<int>();
                for(var i = 0; i < 3; i++)
                {
                    var min = numbers.Min();
                    newList.Add(min);
                    numbers.Remove(min);
                }
                Console.WriteLine("The three smallest numbers are: " + string.Join(',', newList));
            }
        }

    }
}