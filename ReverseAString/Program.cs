using System;

namespace ReverseAString
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("***REVERSE A STRING***\n\n Input string:");

			string input = Console.ReadLine(); 
			string result = "";

			for(int i = input.Length -1; i >= 0; i--) {
				result += input[i];
			}

			Console.WriteLine(result);
		}
	}
}
