
namespace UnitTestsForAreaLibrary
{
	public class TriangleTests
	{
		[Theory]
		[InlineData(3, 4, 5, 6)]
		[InlineData(5, 12, 13, 30)]
		[InlineData(7, 24, 25, 84)]
		public void CalculateTriangleArea_ReturnsCorrectArea(double side1, double side2, double side3, double expectedArea)
		{
			// Arrange
			var triangle = new Triangle(side1, side2, side3);

			// Act
			double area = AreaCalculator.GetArea(triangle);

			// Assert
			Assert.Equal(expectedArea, area);
		}

		[Theory]
		[InlineData(3, 4, 5)]
		[InlineData(5, 12, 13)]
		[InlineData(7, 24, 25)]
		public void IsRectangularTriangle_ReturnsTrue(double side1, double side2, double side3)
		{
			// Arrange
			var triangle = new Triangle(side1, side2, side3);

			// Act
			bool isReactangular = triangle.IsRectangular();

			// Assert
			Assert.True(isReactangular);
		}

		[Theory]
		[InlineData(3, 4, 6)]
		[InlineData(5, 12, 14)]
		[InlineData(7, 24, 26)]
		public void IsRectangularTriangle_ReturnsFalse(double side1, double side2, double side3)
		{
			// Arrange
			var triangle = new Triangle(side1, side2, side3);

			// Act
			bool isReactangular = triangle.IsRectangular();

			// Assert
			Assert.False(isReactangular);
		}


		[Fact]
		public void ConstructorTriangle_WithNegativeSide_ThrowsArgumentOutOfRangeException()
		{
			// Act & Assert
			var exception = Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-3, 4, 5));
			Assert.IsType<ArgumentOutOfRangeException>(exception);
		}
		[Fact]
		public void ConstructorTriangle_WithZeroSide_ThrowsArgumentOutOfRangeException()
		{
			// Act & Assert
			var exception = Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 4, 5));
			Assert.IsType<ArgumentOutOfRangeException>(exception);
		}
		[Fact]
		public void ConstructorTriangle_WithInvalidSides_ThrowsArgumentException()
		{
			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
			Assert.IsType<ArgumentException>(exception);
		}

	}

}