using System;
using System.IO;
namespace Mosh
{
    class ReadTextFile
    {
        static void Main(string[]args)
        {
            //Write a program that reads a text file and displays the number of words.
            var textFile = @"C:/Users/user/Documents/Web3.txt";
            var words = File.ReadAllText(textFile).Split(" ");
            var list = new List<string>();
            foreach(var word in words)
            {
                var newWord = word.Trim();
                list.Add(newWord);
            }
            Console.WriteLine("This file contains {0} words", list.Count);
        }
    }
}
