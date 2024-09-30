using AreaLibrary;
namespace ExternalClient
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Circle myCircle = new Circle(5);
				double squareCircle = AreaCalculator.GetArea(myCircle);
				Console.WriteLine($"S круга = {squareCircle}");

				Triangle myTriangle = new Triangle(3, 4, 5);
				double squareTriangle = AreaCalculator.GetArea(myTriangle);
				bool isRectangular = myTriangle.IsRectangular();
				Console.WriteLine($"S треугольника = {squareTriangle}, {(isRectangular ? "является прямоугольным" : "не является прямоугольным")}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Ошибка: {ex.Message}");
			}
		}
	}
}