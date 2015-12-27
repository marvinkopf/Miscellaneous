using System;

namespace EvenFibonacciNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int result = 0;
			for(int i = 2, j = 1, g = 1; i < 4000000; g = i, i += j, j = g) 
				if(i % 2 == 0)
					result += i;
			Console.WriteLine (result);
		}
	}
}
