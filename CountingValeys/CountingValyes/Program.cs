using System;

namespace ConsoleApp2
{
	class Program
	{
		public static int countingValleys(int steps, string path)
		{
			int seaLevel = 0;
			char last = path[0];
			int valeys = 0;

			for (int i = 0; i < steps; i++)
			{
				if (seaLevel == 0 && path[i] == 'D')
					valeys++;

				if (path[i] == 'U')
					seaLevel++;
				else
					seaLevel--;
			}
			return valeys;
		}

		static void Main(string[] args)
		{
			string path = "DDUUDDUDUUUD";
			int n = 12;
			var res = countingValleys(n, path);

			Console.WriteLine("res=" + res);
		}
	}
}
