using System;
namespace Mosh
{
    class PascalCase
    {
        static void Main(string[] args)
        {
            /*Write a program and ask the user to enter a few words separated by a space. 
             * Use the words to create a variable name with PascalCase. 
             * Make sure that the program is not dependent on the input.*/ 
            Console.Write("Enter a few words separated by a space: ");
            var input = Console.ReadLine();
            var words = input.ToLower().Split(' ');

            foreach(var word in words)
            {
                var tempWord = word;
                var uppWord = Convert.ToString(tempWord[0]).ToUpper();
                Console.Write(string.Concat(uppWord, tempWord.Substring(1)));
            }
        }
    }
}
