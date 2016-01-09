using System;

namespace ReverseAString
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("***REVERSE A STRING***\n\n Input string:");

			string input = Console.ReadLine(); 

			string result = input.Reverse(); 

			Console.WriteLine(result);
		}
	}

	public static class ReverseAString {
		public static string Reverse(this string input) {
			string result = "";

			for(int i = input.Length -1; i >= 0; i--) {
				result += input[i];
			}

			return result;
		}
	}
}


