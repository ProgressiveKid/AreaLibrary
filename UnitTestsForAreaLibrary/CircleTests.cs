
namespace UnitTestsForAreaLibrary
{
	public class CircleTests
	{
		[Theory]
		[InlineData(5, 78.5)]
		[InlineData(2, 12.56)]
		[InlineData(14.1, 624.26)]
		public void CalculateCircleArea_ReturnsCorrectArea(double radius, double expectedArea)
		{
			// Arrange
			var circle = new Circle(radius);

			// Act
			double area = AreaCalculator.GetArea(circle);

			// Assert
			Assert.Equal(expectedArea, area, 2);
		}
		[Fact]
		public void ConstructorCircle_WithInvalidRadius_ThrowsArgumentException()
		{
			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() => new Circle(-2));
			Assert.IsType<ArgumentException>(exception);
		}
	}
}
