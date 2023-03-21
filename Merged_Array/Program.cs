using System;  
public class MergedArrays
{  
    public static void Main() 
{   //Questin: Write a program in C# Sharp to merge two arrays of same size sorted in ascending and descending order.

	int[] firstarr;
	int[] secarr;
	int[] mergedarr;
	
       Console.WriteLine("Hello User! \nThis is a program that merges two arrays sorted in ascendiing and descending order.");
    /*----------------- Getting array length and elements for the first array------------------------------------*/
	   Console.Write("Number of elements to be stored in the first array = ");
	   int firstsize = Convert.ToInt32(Console.ReadLine()); 
       firstarr = new int[firstsize];	   

       Console.WriteLine($"Input {firstsize} elements in the array :");
       for(int i=0; i<firstsize; i++)
        {
	      Console.Write($"Element [{i}] = ");
	     firstarr[i] = Convert.ToInt32(Console.ReadLine()); 		  
	    }
        
    /*----------------- Getting array length and elements for the second array------------------------------------*/
       Console.Write("\nNumber of elements to be stored in the second array = ");
	   int secsize = Convert.ToInt32(Console.ReadLine()); 
       secarr = new int[secsize];	   
   
       Console.WriteLine($"Input {secsize} elements in the array :");
       for(int i=0; i<secsize; i++)
        {
	      Console.Write($"Element [{i}] = ");
	      secarr[i] = Convert.ToInt32(Console.ReadLine()); 		  
	    }
    /* size of merged array is size of first array +  size of second array */
        int mergedsize = firstsize + secsize;
        mergedarr = new int[mergedsize];
     
/*----------------- Elements are inserted in the third array------------------------------------*/
    for(int i=0; i < firstsize; i++)
        {
            mergedarr[i] = firstarr[i];
        }
        int j = firstsize;
        int l = 0;
        while(j < mergedsize)
        {
                mergedarr[j] = secarr[l];
                j +=1;
                l +=1;            
        }
/*----------------- sort the array in ascending order ---------------------------*/
    Array.Sort(mergedarr);
    Console.Write("\nArray sorted in ascending order: ");
    for(int k=0; k < mergedsize; k++)
    {
        Console.Write($"{mergedarr[k]} ");
    }
/*----------------- sort the array in descending order ---------------------------*/
    Array.Sort(mergedarr, delegate(int a, int z){return z - a;});
    Console.Write("\nArray sorted in descending order: ");
    for(int k=0; k < mergedsize; k++)
    {
        Console.Write($"{mergedarr[k]} ");
    }
  }
}

