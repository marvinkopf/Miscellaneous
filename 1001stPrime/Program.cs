using System;

namespace stPrime
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int counterOfPrimeNumber = 0;
			for(ulong i = 1; i*i <= ulong.MaxValue ;i++) {
				ulong count = 0;
				for(ulong j = 1; j <= i; j++) {
					if(i%j==0) {
						count++;
						if(count > 2)
							break; 
					}
				}
				if (count == 2) {
					counterOfPrimeNumber++;
					if(counterOfPrimeNumber == 10001)
						Console.WriteLine(i);
				}
			}

		}
	}
}
