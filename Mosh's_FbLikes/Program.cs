using System;
using System.Collections.Generic;
namespace Mosh
{
    class FbLikes
    {
        static void Main(string[]args)
        {
            /*Write a program and continuously ask the user to enter different names, 
             ...until the user presses Enter (without supplying a name). 
             Depending on the number of names provided, 
             ...display a message based on the pattern with which you were instructed by Mosh.*/
             var names = new List<string>();
             Console.WriteLine("Note: Press \"Enter\" to exit");
             while(true)
             {
                Console.Write("Enter a name: ");
                var name = Console.ReadLine();
                if(name == "")
                {
                    break;
                }
                names.Add(name);
             }
             var count = names.Count;
             if (count == 1)
             {
                Console.WriteLine("{0} liked your post", names[0]);
             }
             else if (count == 2)
             {
                Console.WriteLine("{0} and {1} liked your post", names[0],names[1]);
             }
             else if(count > 2)
             {
                Console.WriteLine("{0},{1} and {2} others liked your post", names[0], names[1], count-2);
             }
        }
    }
}
