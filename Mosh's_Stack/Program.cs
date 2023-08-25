using System;
namespace Intermediate
{
    class UsingStack
    {
        /*Design a class called Stack with three methods.
             *void Push(object obj): stores the given object on top of the stack.
             *object Pop(): removes the object on top of the stack and returns it. 
             *void Clear(): removes all objects from the stack
            */
        static void Main (string[]args)
        {
            var stack = new Stack();
            Console.WriteLine("Welcome to a stack.\n\tSelect: \nAdd\tRemove\tClear\tQuit");
                   
            while(true)
            {
                string choice = Console.ReadLine();
                stack.Check(choice); 

                if(choice.ToLower() == "quit")
                    break;
                switch(choice.ToLower())
                {
                    case "add":
                    Console.Write("Add: ");
                    object obj = Console.ReadLine();
                    stack.Push(obj);
                    break;

                    case "remove":
                    object removed = stack.Pop();
                    stack.ObjType(removed);
                    break;

                    case "clear":
                    stack.Clear();
                    Console.WriteLine("Stack has beeen cleared");
                    break;

                    
                    default:
                    throw new InvalidOperationException ("Invalid Option");
                }
                Console.WriteLine("\nAdd\tRemove\tClear\tQuit");
            }
        }
    }
}