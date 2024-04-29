using System;
namespace OP_L4
{
	public class Polynomial
	{
		public double a;
		public double b;
		public double c;

		public void Solution()
		{
			if (a != 0)
			{
				double d = Math.Pow(b, 2) - 4 * a * c;
				if (d > 0)
				{
					double x1 = (-1 * b + Math.Sqrt(d)) / (2 * a);
					double x2 = (-1 * b - Math.Sqrt(d)) / (2 * a);
					Console.WriteLine($"Корни уравнения: {Math.Round(x1,2)} и {Math.Round(x2,2)}");
				}
				else if (d == 0)
				{
					double x = (-1 * b) / (2 * a);
					Console.WriteLine($"Корень уравнения: {Math.Round(x,2)}");
				}
				else
				{
					Console.WriteLine("Нет корней");
				}
			}
			else if (b!=0)
			{
				double x = (-1 * c) / b;
                Console.WriteLine($"Корень уравнения: {Math.Round(x, 2)}");
            }
			else
			{
				double x = c;
                Console.WriteLine($"Корень уравнения: {x}");
            }
		}
	}
}

