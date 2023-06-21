using System;
namespace Mosh
{
    class Validation
    {
        static void Main(string[]args)
        {
            /*Write a program and ask the user to enter the width and height of an image. 
             *Then tell if the image is landscape or portrait.*/
             Console.Write("Enter the values for the following properties of an image; \nwidth(px) = ");
             var width = Convert.ToInt32(Console.ReadLine());
             Console.Write("height(px) = ");
             var height = Convert.ToInt32(Console.ReadLine());
             if (width == 1920 && height == 1080)
             {
                Console.WriteLine("The image is a Landscape");
             }
             else if (width == 1080 && height == 1920)
             {
                Console.WriteLine("The image is a Portrait");
             }
             else
             {
                Console.WriteLine("The image size is not defined");
             }
        }
    }
}
