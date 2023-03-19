using System;
namespace Exercices
{
	class Arr_AssignI
	{
		static void Main(string[]args)
		{
			//Question 1
			//Write a program in C# to store elements in an array and print it
			/*Test Data:
			 * Input 10 elements in the array
			 * element -0 : 1
			 * element -1 : 1
			 * element -2 : 2
			 * .............
			 * Expected output:
			 * Elements in  array are : 1 1 2 3 4 5 6 7 8 9
			 */
			Console.WriteLine("Solution 1");
			Console.WriteLine("Input 10 elements in the array");
			int[] arr = new int[10];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.Write("\nElements in array are :");
			foreach(int item in arr)
			{
				Console.Write(arr[item] + " ");
			}
			Console.WriteLine("\nSolution 2");

			//Question 2
			//Write a C# program to declare, initialize, input elements in array and print array
			/*Test Data:
			 * Enter size of array:6
			 * Enter 6 elements in the array...
			 */
			Console.Write("\nEnter size of array : ");
			int size = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"\nEnter {size} elements in the array");
			int[] elements = new int[size];
			for(int j = 0; j < elements.Length; j++)
			{
				elements[j] = Convert.ToInt32(Console.ReadLine());
			}
			Console.Write("\nElements in array are : ");
			for(int k = 0; k < elements.Length; k++)
			{
				Console.Write(elements[k] + " ");
			}


		}
	}
}
