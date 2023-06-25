using System;
namespace Mosh
{
    class ReversedName
    {
        static void Main(string[]args)
        {
            /*Write a program and ask the user to enter their name. 
              Use an array to reverse the name and then store the result in a new string. 
              Display the reversed name on the console.*/
              Console.Write("Enter your name: ");
              var name = Console.ReadLine();
              var nameArr = new char[name.Length];
              for(var i = 0; i < name.Length; i++)
              {
                nameArr[i] = name[i];
              }
              Array.Reverse(nameArr);
              string newName = new string(nameArr);
              Console.WriteLine("Name in reversed order: {0}", newName);
        }
    }
}
