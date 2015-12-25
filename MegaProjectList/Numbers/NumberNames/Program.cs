using System;

namespace NumberNames
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("***Number Names***\n\nInput a number!\n\n");

			int inputnumber = int.Parse (Console.ReadLine ());

			Console.WriteLine ("\n\n");

			string output = ""; 

			while (inputnumber >= 1000) {
				int count = inputnumber >= 1000000 ? 1000000 : 1000;
				string name = inputnumber >= 1000000 ? "million" : "thousand";
				output += SolveFor (inputnumber, count, name);
				inputnumber = inputnumber - (inputnumber / count) * count;
			}

			Console.Write (output);

			Console.Write (SolveFor(inputnumber, 1, ""));

		}

		public static string SolveFor (int inputnumber, int count, string name)
		{
			string returnstring = "";

			returnstring += (GetNameOf2DigitNumber ((inputnumber -
				inputnumber /(count*100) * 100) / count));

			if (inputnumber / (count * 100) > 0) {
				returnstring = (GetNameOf2DigitNumber (inputnumber / (count * 100))
				+ "hundred") + returnstring;
			}
			
			return returnstring + name;
		}

		public static string GetNameOf2DigitNumber (int number)
		{ 
			if (number >=100)
				return "";
			
			switch (number) {
			case 10:
				return "ten";
			case 11:
				return "eleven";
			case 12:
				return "twelve";
			}
			if (number / 90 == 1)
				return "ninety" + GetNameOfDigit (number % 90);
			if (number / 80 == 1)
				return "eighty" + GetNameOfDigit (number % 80);
			if (number / 70 == 1)
				return "seventy" + GetNameOfDigit (number % 70);
			if (number / 60 == 1)
				return "sixty" + GetNameOfDigit (number % 60);
			if (number / 50 == 1)
				return "fifty" + GetNameOfDigit (number % 50);
			if (number / 40 == 1)
				return "fourty" + GetNameOfDigit (number % 40);
			if (number / 30 == 1)
				return "thirty" + GetNameOfDigit (number % 30);
			if (number / 20 == 1)
				return "twenty" + GetNameOfDigit (number % 20);
			if (number / 10 == 1)
				return GetNameOfDigit (number) + "teen";
			

			return GetNameOfDigit (number);
		}

		public static string GetNameOfDigit (int digit)
		{
			switch (digit) {
			case 1:
				return "one";
			case 2:
				return "two";
			case 3:
				return "three";
			case 4:
				return "four";
			case 5:
				return "five";
			case 6:
				return "six";
			case 7:
				return "seven";
			case 8:
				return "eight";
			case 9:
				return "nine";
			}

			return "";
		}
	}
}
