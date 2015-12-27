using System;

namespace SmallestMultiple
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int min = int.MaxValue;
			for(int i = 1; min == int.MaxValue && i <= int.MaxValue; i++) {
				for(int j = 2; j<= 20; j++) {
					if(i % j != 0)
						break;
					if(j == 20)
						min = i;
				}
			}
			Console.WriteLine (min);
		}
	}
}
