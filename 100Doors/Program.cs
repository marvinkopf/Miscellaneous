using System;

namespace Doors
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("***100 DOORS***\n--------\n");

			bool[] doors = new bool[100];

			for (int i = 1; i <= 100; i++) 
				for (int j = i - 1; j < 100; j += i) 
					doors [j] = !doors [j];
				
			for (int i = 0; i < 100; i++)
				Console.Write ("\nDoor #{0} is: {1}", i+1, doors [i] ? "Open" : "Closed");

		}
	}
}
