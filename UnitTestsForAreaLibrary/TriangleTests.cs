using System;
using Xunit;
using AreaLibrary;  // Не забудьте заменить на ваш актуальный namespace

public class TriangleTests
{
	[Fact]
	public void CalculateArea_ValidTriangle_ReturnsCorrectArea()
	{
		// Arrange
		var triangle = new Triangle(3, 4, 5);

		// Act
		double area = triangle.CalculateArea();

		// Assert
		Assert.Equal(6, area, 1); // Ожидаемое значение площади 6 (с точностью 1)
	}

	[Fact]
	public void IsValid_ValidTriangle_ReturnsTrue()
	{
		// Arrange
		var triangle = new Triangle(3, 4, 5);

		// Act
		bool isValid = triangle.IsValid();

		// Assert
		Assert.True(isValid);
	}

	[Fact]
	public void IsValid_InvalidTriangle_ReturnsFalse()
	{
		// Arrange
		var triangle = new Triangle(1, 2, 3);

		// Act
		bool isValid = triangle.IsValid();

		// Assert
		Assert.False(isValid);
	}

	[Fact]
	public void CalculateArea_InvalidTriangle_ThrowsInvalidOperationException()
	{
		// Arrange
		var triangle = new Triangle(1, 2, 3);

		// Act & Assert
		var exception = Assert.Throws<InvalidOperationException>(() => triangle.CalculateArea());
		Assert.Equal("Треугольник с такими сторонами не существует", exception.Message);
	}
}
