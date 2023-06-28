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
            if(String.IsNullOrWhiteSpace(input)){return;}

            var words = input.ToLower().Split(' ');
            foreach(var word in words)
            {
                var tempWord = word;
                Console.Write(string.Concat(char.ToUpper(tempWord[0]), tempWord.Substring(1)));
            }
        }
    }
}
