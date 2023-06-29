using System;
using System.IO;
using System.Collections.Generic;
namespace Mosh
{
    class LongestWord
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file and displays the longest word in the file.
            var textFile = @"C:/Users/user/Documents/Web3.txt";
            var words = File.ReadAllText(textFile).Split(" ");
            var list = new List<string>();
            var index = new List<int>();
            foreach (var word in words)
            {
                var newWord = word.Replace('\t', ' ').Trim();
                var length = newWord.Length;
                list.Add(newWord);
                index.Add(length);
            }
            var longest = index.IndexOf(index.Max());
            Console.WriteLine("The longest word: \"{0}\"", list[longest]);
        }
    }
}