using System;

namespace HW2
{
	class Program
	{
		static void Main(string[] args)
		{
			int i, count, f1 = 0, f2 = 1, f3 = 0;
			Console.Write("Enter the Limit : ");
			count = int.Parse(Console.ReadLine());

			for (i = 0; i <= count; i++)
			{
				f3 = f1 + f2;
				Console.WriteLine(Math.Max(f3,0));
				f1 = f2;
				f2 = f3;
			}
			Console.ReadLine();
		}
	}
}
