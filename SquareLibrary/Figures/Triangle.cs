
namespace AreaLibrary
{
	public class Triangle : IFigure
	{
		private double A { get; set; }
		private double B { get; set; }
		private double C { get; set; }


		public Triangle(double a, double b, double c)
		{
			A = a;
			B = b;
			C = c;
		}
		/// <summary>
		/// Проверяет, существует ли треугольник с заданными сторонами
		/// </summary>
		/// <returns>True, если треугольник существует, иначе false</returns>
		public bool IsValid()
		{
			return A + B > C && A + C > B && B + C > A;
		}

		/// <summary>
		/// Вычисление площади треугольника по формуле Герона через полупериметр
		/// </summary>
		/// <returns></returns>
		public double CalculateArea()
		{
			if (!IsValid())
			{
				throw new InvalidOperationException("Треугольник с такими сторонами не существует");
			}
			double S = (A + B + C) / 2;
			return Math.Sqrt(S * (S - A) * (S - B) * (S - C));
		}

		public bool isPriamaugol()
		{ //TODO проверка на является ли , является ли треугольник прямоугольным
			return true;
		}
	}
}
