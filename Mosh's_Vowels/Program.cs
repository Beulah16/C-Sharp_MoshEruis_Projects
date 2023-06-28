using System;
namespace Mosh
{
    class Vowels
    {
        static void Main()
        {
            /*Write a program and ask the user to enter an English word.
             * Count the number of vowels in the word and display on the console.*/

            Console.Write("Enter an English word: ");
            var input = Console.ReadLine().ToLower();
            if (String.IsNullOrWhiteSpace(input)) { }
            else
            {
                var chars = input.ToCharArray();
                var vowelNum = 0;
                foreach (char ch in chars)
                {
                    switch (ch)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            vowelNum++;
                            break;
                    }
                }
                Console.Write($"{vowelNum} vowels present");
            }
        }
    }
}
