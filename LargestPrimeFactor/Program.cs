using System;

namespace LargestPrimeFactor
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ulong n = 600851475143;
			ulong max = 0;

			for(ulong i = 1; i*i <= n ;i++) {
				if(n % i != 0)
					continue;

				ulong count = 0;
				for(ulong j = 1; j <= i; j++) {
					if(i%j==0) {
						count++;
						if(count > 2)
							break; 
					}
				}
				if (count == 2) {
					max = i;
				}
			}
			Console.WriteLine (max);
		}
	}
}
