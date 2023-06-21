using System;
namespace Mosh
{
    class SpeedLimit
    {
        static void Main(string[]args)
        {
            /*Write a program that asks the user to enter the speed limit. 
             *Once set, the program asks for the speed of a car. 
             *If the user enters a value less than the speed limit, program should display Ok on the console. 
             *If the value is above the speed limit, the program should calculate the number of demerit points. 
             *For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
             *If the number of demerit points is above 12, the program should display License Suspended.*/
             Console.Write("Enter the Speed limit(km/hr) : ");
             var speedlimit = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter the Speed of the (km/hr) : ");;
             var carspeed = Convert.ToInt32(Console.ReadLine());
             var demerit = 0;
             if (carspeed > speedlimit)
             {
                var rem = carspeed - speedlimit;
                demerit = rem/5;
                Console.WriteLine("Demerit points = {0}",demerit);
                if(demerit > 12)
                {
                    Console.WriteLine("License Suspended!");
                }
             }
             else
             {
                Console.WriteLine("Ride On!");
             }
        }
    }
}
