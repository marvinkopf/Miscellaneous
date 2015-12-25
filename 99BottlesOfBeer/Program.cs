using System;

namespace BottlesOfBeer
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("***99 Bottles of Beer***");

			for(int i = 99; i > 0; i--) {
				Console.Write("\n{0} bottles of beer on the wall \n" +
					"{0} bottles of beer \nTake one down, pass it around \n" +
					"{1} bottles of beer on the wall\n", i, i-1);
			}

			Console.WriteLine("\nNo more bottles of beer on the wall, no more bottles of beer.\n" +
				"Go to the store and buy some more, 99 bottles of beer on the wall.");
		}
	}
}
