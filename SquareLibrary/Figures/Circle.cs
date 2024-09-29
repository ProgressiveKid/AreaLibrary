namespace AreaLibrary
{
	/// <summary>
	/// Геометрическая фигура - круг
	/// </summary>
	public class Circle : IFigure
	{
		public double Radius { get; set; }

		public Circle(double radius)
		{
			Radius = radius;
		}
		/// <summary>
		/// S = π ⋅ R^2 
		/// </summary>
		public double CalculateArea()
		{
			return Math.PI * Radius * Radius;
		}
	}
}
