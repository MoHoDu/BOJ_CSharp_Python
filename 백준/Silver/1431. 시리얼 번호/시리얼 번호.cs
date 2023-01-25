using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace codingTest
{
	public static class BJ1431
	{
		public static List<string> serials = new List<string>();

		public static void Main(string[] args)
		{
			int N;
			int.TryParse(Console.ReadLine(), out N);
			for (int i = 0; i < N; i++)
			{
				var serial = Console.ReadLine();
				if (serial == null) continue;
				serials.Add(serial);
			}
			serials.Sort(new Comparer());

			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < serials.Count; i++)
			{
				sb.Append(serials[i]);
				sb.Append("\n");
			}
			Console.Write(sb);
		}
	}

	public class Comparer : IComparer<string>
	{
		public int Compare(string x, string y)
		{
			if (x.Length == y.Length)
			{
				int xSum = 0;
				int ySum = 0;
				for (int i = 0; i < x.Length; i++)
				{
					int charX = 0;
					int.TryParse(x[i].ToString(), out charX);
					xSum += charX;

					int charY = 0;
					int.TryParse(y[i].ToString(), out charY);
					ySum += charY;
				}
				if (xSum != ySum)
					return (xSum > ySum) ? 1 : -1;
				else
				{
					return string.Compare(x, y);
				}
			}
			else
				return ((x.Length > y.Length) ? 1 : -1);
		}
	}
}