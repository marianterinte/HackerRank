using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			int n = 9;
			List<int> ar = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
			var result = sockMerchant(n, ar);
			Console.WriteLine("nr socks=" + result);

		}

		public static int sockMerchant(int n, List<int> ar)
		{
			Dictionary<int, int> resAr = ar.Distinct().ToDictionary(c => c, c => 0);

			for (int i = 0; i < n; i++)
			{
				if (resAr.ContainsKey(ar[i]))
					resAr[ar[i]] = resAr[ar[i]] + 1;
			}

			int result = resAr.Sum(s => s.Value/2);
			return result;
		}
	}
}
