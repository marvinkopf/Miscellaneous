using System;

namespace CheckIfPalindrome
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("***Check if Palindrome****\n-------------\n");

			string input = Console.ReadLine();
			string s = "";

			for(int i = 0; i < input.Length; i++)
				s = input[i] + s;
		

			if ( input == s)
				Console.Write(true);
			else
				Console.Write(false);

		}
	}
}
