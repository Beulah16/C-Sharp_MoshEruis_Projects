using System;
namespace Exercices
{
	class Arr_AssignII
	{
		static void Main(string[]args)
		{
			//Question 1
			//Write a program in C# Sharp to find the sum of all elements of the array.
			/*Test Data :
			 * Input the number of elements to be stored in the array :3
			 * Input 3 elements in the array :
			 * element - 0 : 2
			 * element - 1 : 5
			 * element - 2 : 8
			 */
			Console.WriteLine("Solution 1");
			Console.Write("Input the number of elements to be stored in the array : ");
			int size = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"Input {size} elements in the array");
			int[] arr = new int[size];
			for(int i = 0; i < arr.Length; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}
			int sum = 0;
			for(int j = 0; j < arr.Length; j++)
			{
				sum += arr[j];
			}
			Console.WriteLine($"Sum of elements = {sum}");

			//Question 2:
			//Write a program in C# Sharp to copy the elements of one array into another array.
			/*Test Data :
			 * Input the number of elements to be stored in the array :3
			 * Input 3 elements in the array :
			 * element - 0 : 15
			 * element - 1 : 10
			 * element - 2 : 12
			 */
			//Expected Output:
			/*The elements stored in the first array are :15 10 12
			 *The elements copied into the second array are :15 10 12
			 */
			Console.WriteLine("\nSolution 2");
			Console.Write("Input the number of elements to be stored in the array : ");
			int num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"Input {num} elements in the array");
			int[] array1 = new int[num];
                        for(int k = 0; k < array1.Length; k++)
			{
				array1[k] = Convert.ToInt32(Console.ReadLine());
                        }
			Console.Write("The elements stored in the first array are : ");
			for(int l = 0; l < array1.Length; l++)
                        {
                                Console.Write(array1[l] + " ");
                        }
			int[] array2 = new int[num];
                        for(int n = 0; n < array1.Length; n++)
                        {
                                array2[n] = array1[n];
                        }

			Console.Write("\nThe elements copied into the second array are : ");
                        for(int m = 0; m < array2.Length; m++)
                        {
                                Console.Write(array2[m] + " ");
                        }

		}
	}
}

