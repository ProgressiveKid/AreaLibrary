
namespace AreaLibrary
{
	/// <summary>
	/// Класс, который вычисляет площадь геометрических фигур
	/// </summary>
	public class AreaCalculator
	{
		/// <summary>
		/// Вычисляет площадь заданной фигуры
		/// </summary>
		/// <param name="figure">Фигура, для которой необходимо рассчитать площадь</param>
		/// <returns>Площадь фигуры в виде цифры с плавающей запятой в см^2 </returns>
		/// <exception cref="ArgumentNullException">Выбрасывается, если форма имеет значение null.</exception>
		public static double GetArea(IFigure figure)
		{
			return figure != null ? figure.CalculateArea() : throw new ArgumentNullException(nameof(figure), "Фигура не может быть null.");
		}
	}
}