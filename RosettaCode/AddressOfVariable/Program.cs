using System;

namespace AddressOfVariable
{
	class MainClass
	{
		public static void Main (string[] args)
		{	
			unsafe {
				int i;
				Console.WriteLine ((int)&i);
			}
		}
	}
}
