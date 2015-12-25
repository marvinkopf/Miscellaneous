using System;

namespace FizzBuzz
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("***FIZZ BUZZ***\n------------------\n");

			for (int i = 1; i <= 100; i++) {
				if (i % 3 == 0) {
					Console.Write ("\nFizz");
					if (i % 5 == 0)
						Console.Write ("Buzz");
				} else if (i % 5 == 0)
					Console.Write ("\nBuzz");
				else
					Console.Write ("\n" + i);
			}

		}
	}
}
