using System;

namespace AB
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("****A+B****\n-----");

			string[] s = Console.ReadLine().Split();

			Console.Write(int.Parse(s[0]) + int.Parse(s[1]));
		}
	}
}
