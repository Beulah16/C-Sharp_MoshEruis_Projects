using System;
namespace Intermediate
{
    class UsingStopwatch
    {
        static void Main(string[]args)
       {
        /*Design a class called Stopwatch whose job is to simulate a stopwatch.
         It should provide two methods: Start and Stop. We call the start method first, and the stop method next. 
         Then we ask the stopwatch about the duration between start and stop which should be a value in TimeSpan. 
         Display the duration on the console.*/
         Console.WriteLine("STOPWATCH \nType in any of the following functions: \n\tStart \n\tStop \n\tQuit");
         var stopwatch = new Stopwatch ();
         while(true)
         {
            var function = Console.ReadLine();
            if(!String.IsNullOrWhiteSpace(function))
            {
                if(function.ToLower() == "quit")
                break;
                switch(function.ToLower())
                {
                    case "start":
                        stopwatch.Start();
                        break;

                    case "stop":
                        stopwatch.Stop();
                        break;
                        
                    default:
                    System.Console.WriteLine("Invalid function!");
                    break; 
                }
            }
            else
            {
                throw new ArgumentNullException ("Input cannot be null!");
            }
         }
       }
    }
}