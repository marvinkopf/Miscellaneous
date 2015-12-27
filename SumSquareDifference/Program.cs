using System;

namespace SumSquareDifference
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int sumSquares = 0;
			int sumNumbers = 0;

			for(int i = 1; i <= 100; i++) {
				sumSquares += i*i;
				sumNumbers += i;
			}

			sumNumbers *= sumNumbers;

			Console.WriteLine(sumNumbers - sumSquares);
		}
	}
}
