using AreaLibrary;
namespace ExternalClient
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				//TODO интерактивное меню с выбором фигуры
				Circle myCircle = new Circle(5);

				Triangle myTriangle = new Triangle(2, 4, 8);
				myTriangle.isPriamaugol();

				double square = AreaCalculator.GetArea(myTriangle);
				Console.WriteLine(square);
				Console.WriteLine("Hello, World!");

			}
			catch (Exception ex)
			{
				Console.WriteLine($"Ошибка: {ex.Message}");
			}
		}
	}
}