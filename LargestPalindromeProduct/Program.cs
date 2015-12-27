using System;

namespace LargestPalindromeProduct
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int max = 0;
			for(int i = 999; i > 0; i--) 
				for(int j = i; j > 0; j--) {
					if( IsPalindrome(i*j))
						max = i*j > max ? i*j : max;
				}

			Console.WriteLine (max);
		}

		public static bool IsPalindrome(int inputNumber) {
			string input = inputNumber.ToString();
			string s = "";

			for(int i = 0; i < input.Length; i++)
				s = input[i] + s;
			
			if ( input == s)
				return true;

			return false; 
		}
	}
}
