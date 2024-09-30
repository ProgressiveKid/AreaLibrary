namespace AreaLibrary
{
	/// <summary>
	/// Геометрическая фигура - круг;
	/// π = 3.14
	/// </summary>
	public class Circle : IFigure
	{
		/// <summary>
		/// Радиус (см)
		/// </summary>
		public double Radius { get; set; }

		public Circle(double radius)
		{
			if (radius <= 0)
			{ // проблема с неверным параметром, переданным в конструктор
				throw new ArgumentException("Радиус должен быть положительным числом");
			}
			Radius = radius;
		}
		/// <summary>
		/// S = π ⋅ R^2 
		/// округление до двух знаков после запятой
		/// </summary>
		public double CalculateArea()
		{
			return Math.Round(Math.Round(Math.PI,2) * Radius * Radius, 2);
		}
	}
}
