using System;
using System.Collections.Generic;

namespace списки
{
	class airport
	{
		
		public void vvod()
		{
			var someList = new List<string>();
			{ 
			};
			Console.WriteLine("введите количество самолетов");
			int n;
			int j = 1;
			n = Convert.ToInt32(Console.ReadLine());
			string[] s = new string[n];
			for (int k = 0; k < n; k++)
			{
				Console.WriteLine("введите название фирмы самолета");
				s[k] = Console.ReadLine();
				someList.Add(s[k]);
			
			}
			
			for (int k = 0; k < n; k++)
			{
				Console.WriteLine(j + " самолет: " + s[k]);
				j++;
			
			}
			foreach (var L in someList)
			{
				Console.WriteLine(L);
			}
			Console.WriteLine();
		}
		public void vivod()
		{ 
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			airport A = new airport();
			A.vvod();
			
		}
	}
}