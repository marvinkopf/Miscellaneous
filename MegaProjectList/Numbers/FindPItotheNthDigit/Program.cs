using System;

namespace FindPItotheNthDigit
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("***Find PI to the Nth Digit*** \nEnter a number: ");
			int piLength = 0;

			while (true) {
				piLength = int.Parse(Console.ReadLine()) + 1;

				if (piLength <= 100000) {
					break;
				}

				Console.WriteLine("Number too high! \nEnter a Number: ");
			}
		
			int m = 10*(piLength)/3;
			int[,] result = new int[piLength +3, m + 1];

			for(int i = 1; i<m; i++) {
				result[0, i+1] = i;
				for(int j = 3; result[1,i+1]==0; j++)
					if(j>result[1, i] && IsOdd(j)) 
						result[1,i+1] = j; 
			}

			for(int i = 1; i < m+1; i++) {
				result[2,i] = 2;
			}

			int lastSecuredDigit = 0;
			for(int i = 0; i < piLength; i++) {
				for(int j = m ; j > 0; j--) {
					int tmp = result[i+2,j] * 10 + result[i+3,j];
					if(j>1) { 
						result[i+3,j] = tmp % result[1,j];
						result[i+3,j-1] = (tmp / result[1,j]) * result[0,j];
					}
					else {
						result[i+3,j] = tmp % 10;
						result[i+3,j-1] = 
							int.Parse((tmp / 10).ToString()[(tmp / 10).ToString().Length-1].ToString());
					}
				}

				int preliminaryNextDigit = result[i+2,0] * 10 + result[i+3,0];
				result[i+3,0] = preliminaryNextDigit % 10;
				preliminaryNextDigit = preliminaryNextDigit / 10;

				if(preliminaryNextDigit<=8)
					lastSecuredDigit = i+3;
				else if(preliminaryNextDigit == 10) {
					for(int t = lastSecuredDigit + 1; t < piLength && t < i +3; t++)
						result[t,0]++;
					result[i+3,0] = 0;
				}
			}

			Console.Write("\nErgebnis: 3,");
			for(int i = 4; i < piLength +3; i++) {
				Console.Write(result[i,0]);
			}

			Console.Write("\n\n");

			#if DEBUG
			for(int i = 0; i < result.GetLength(0);i++) {
					for(int j = 0; j < result.GetLength(1);j++)
					Console.Write(result[i,j] + "\t");
				Console.Write("\n");
			}
			#endif
		}
			
		public static bool IsOdd(int number) {
			if(number % 2 != 0)
				return true;
			return false;
		}
	}
}


