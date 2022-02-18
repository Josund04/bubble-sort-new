using System;
using System.Diagnostics;

namespace bubble_sort
{
    class Program
    {
        
      static void Main(string[] args) {
    
	
		Random rnd = new Random();
	int[] arr = new int[4000];
    for (int j = 0; j < 4000; j++)
		{
			arr[j]=(rnd.Next(1,4000)); // returns random integers >= 10 and < 19
		}
	

         Stopwatch stop=Stopwatch.StartNew();
         stop.Start();
         
         int temp;
         for (int j = 0; j <= arr.Length - 2; j++) {
            for (int i = 0; i <= arr.Length - 2; i++) {
               if (arr[i] > arr[i + 1]) {
                  temp= arr[i + 1];
                  arr[i + 1] = arr[i];
                  arr[i] = temp;
               }
            }
         }
         stop.Stop(); 

         Console.WriteLine("Sorted:");
         foreach (int p in arr)
            Console.Write(p + " ");
            Console.WriteLine(" ");
            Console.WriteLine("tid = " + stop.ElapsedMilliseconds + " ms"); 
         Console.Read();
      }
   }
}