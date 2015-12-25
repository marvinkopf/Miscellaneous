using System;

namespace NextPrimeNumber
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("***Next Prime Number***\n\n" +
				" Use n to get a new prime number or q to quit!");

			int currentNumber = 2; 

			while(true) {
			string input = Char.ToString((char)Console.Read()); 
				Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
				if(input == "n") {
					for(int i = currentNumber; ;i++) {
						int count = 0;
						for(int j = 1; j <= i; j++) {
							if(i%j==0) {
								count++;
								if(count > 2)
									break; 
							}
						}
						if (count == 2) {
							Console.WriteLine(i);
							currentNumber = i+1;
							break;
						}
					}
				}
				else if(input == "q")
					break;

		}
		}
	}
}
