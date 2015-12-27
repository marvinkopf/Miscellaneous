using System;

namespace StringIterator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string s = "Hello World! .";
			StringIterator si = new StringIterator(s);
			Console.WriteLine (si.HasNext());
			Console.WriteLine (si.Next());
			Console.WriteLine (si.Next());
			Console.WriteLine (si.HasNext());
			Console.WriteLine (si.Next());
			Console.WriteLine (si.HasNext());
		}
	}

	class StringIterator {
		public StringIterator(string s) {
			wordCollection = s.Split(' '); 
		}

		private int pointer = 0; 
		private string[] wordCollection; 

		public bool HasNext() {
			if(pointer == wordCollection.Length)
				return false;

			return true;
		}

		public string Next() {
			pointer++;
			return wordCollection[pointer - 1];
		}
	}
}
