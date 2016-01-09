using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenFibonacciNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int result = 0;
			result = SumEvenFibonacciRecursive ();
			Console.WriteLine (result);

			result = SumEvenFibonacciIterative ();
			Console.WriteLine (result);

			// additionally: nth fibonacci number 
			Console.WriteLine (FibonacciIterative ().ElementAt (40)); 
			Console.WriteLine (FibonacciRecursive ().ElementAt (40));
		}

		public static int SumEvenFibonacciIterative ()
		{
			return SumEvenFibonacci (FibonacciIterative ());
		}

		public static int SumEvenFibonacciRecursive ()
		{
			return SumEvenFibonacci (FibonacciRecursive ());
		}

		public static int SumEvenFibonacci (IEnumerable<int> method)
		{
			return method.TakeWhile (x => x < 4000000).Where (x => x % 2 == 0).Sum ();
		}

		public static IEnumerable<int> FibonacciIterative ()
		{
			for (int i = 1, j = 0; i >= j; i += j, j = i - j)
				yield return i; 
		}

		public static IEnumerable<int> FibonacciRecursive (int i = 1, int j = 0)
		{
			if (i < j)
				yield break;
			
			yield return i;

			foreach (int g in FibonacciRecursive(i+j,i))
				yield return g;
		}
	}
}
