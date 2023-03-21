using System;

class OccuringOdd
{
	public static void Main()
	{
		//Find the number occuring odd number of times
		int[] arr = {2, 3, 5, 4, 5, 2, 4, 3, 5, 2, 4, 4, 2,};
		int count2 = 0;
		int count3 = 0;
		int count4 = 0;
		int count5 = 0;
		for(int i = 0; i < arr.Length; i++)
		{
			int temp = arr[i];
			if(temp == 2)
			{
				count2 += 1;
			}
			if(temp == 3)
			{
				count3 += 1;
			}
			if(temp == 4)
			{
				count4 += 1;
			}
			if(temp == 5)
			{
				count5 += 1;
			}
		}
		if(count2 % 2 != 0)
		{
			Console.WriteLine("2 is occurring odd number of times");
		}
		if(count3 % 2 != 0)
		{
			Console.WriteLine("3 is occurring odd number of times");
		}
		if(count4 % 2 != 0)
		{
			Console.WriteLine("4 is occurring odd number of times");
		}

		if(count5 % 2 != 0)
		{
			Console.WriteLine("5 is occurring odd number of times");
		}
	}
}
