using System;

namespace StringIterator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string s = " ";
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
			_input = s; 

			for(int i = 0; i < _input.Length; i++) 
				if(!_input[i].Equals(' ')) {
					_pointer = i; 
					break;
				}
			
		}

		private int _pointer = 0; 
		private string _input;

		public bool HasNext() {
			for(int i = _pointer; i < _input.Length; i++)
				if(_input[i] != ' ') 
					return true;
			return false;
		}

		public string Next() {
			if(!HasNext())
				throw new Exception();

			while(_input[_pointer].Equals(' '))
				_pointer++; 

			string next = "";

			while(_pointer < _input.Length) {
				if(_input[_pointer].Equals(' '))
					break; 
				
				next += _input[_pointer];

				_pointer++;
			}

			return next; 
		}
	}
}
