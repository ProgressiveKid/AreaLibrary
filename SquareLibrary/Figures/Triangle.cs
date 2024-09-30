
namespace AreaLibrary
{
	/// <summary>
	/// Геометрическая фигура - треугольник 
	/// </summary>
	public class Triangle : IFigure
	{
		
		private double A { get; set; }
		private double B { get; set; }
		private double C { get; set; }
		/// <summary>
		/// Стороны треугольника задаются в см
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public Triangle(double a, double b, double c)
		{

			if (a <= 0 || b <= 0 || c <= 0)
			{ // проблема с неверными параметрами, переданными в конструктор
				throw new ArgumentOutOfRangeException("Стороны треугольника должны быть положительными");
			}
			if (!(a + b > c && a + c > b && b + c > a))
			{ // проблема с неверными параметрами, переданными в конструктор
				throw new ArgumentException("Треугольник с такими сторонами не может быть создан - сумма двух сторон должна быть больше третьей стороны");
			}

			A = a;
			B = b;
			C = c;
		}

		/// <summary>
		/// Вычисление площади треугольника по формуле Герона через полупериметр
		/// </summary>
		/// <returns>Площадь треугольника</returns>
		public double CalculateArea()
		{
			double p = (A + B + C) / 2;
			double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

			return S;
		}

		/// <summary>
		/// Проверяем, является ли треугольник прямоугольным с помощью теоремы Пифагора
		/// </summary>
		/// <returns>True, если треугольник является прямоугольным, иначе false</returns>
		public bool IsRectangular()
		{ 
			double [] arrSide = { A, B, C }; 
			double maxSide = arrSide.Max(); 
			int index = Array.IndexOf(arrSide, maxSide);
			double leftSum = Math.Pow(maxSide, 2);
			double rightSum = arrSide.Where((u, i) => i != index).Select(u=>Math.Pow(u,2)).Sum();

			return leftSum == rightSum ? true : false;
		}
	}
}
