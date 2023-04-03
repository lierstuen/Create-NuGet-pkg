using MathHelper.Implementation;
using MathHelper.Interfaces;
using NUnit.Framework;

namespace MathHelper.Tests;

[TestFixture]
public class CalculatorTests
{
    private readonly ICalculator _calculator;
    
    public CalculatorTests()
    {
        _calculator = new Calculator();
    }
    
    [Test]
    public void Given_No_Arguments_When_Adding_Then_Returns_Zero()
    {
        // Given
        double[] numbers = new double[0];

        // When
        double result = _calculator.Add(numbers);

        // Then
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Given_One_Argument_When_Adding_Then_Returns_That_Number()
    {
        // Given
        double[] numbers = new double[] { 3 };

        // When
        double result = _calculator.Add(numbers);

        // Then
        Assert.AreEqual(3, result);
    }

    [Test]
    public void Given_Two_Arguments_When_Adding_Then_Returns_The_Sum()
    {
        // Given
        double[] numbers = new double[] { 2, 3 };

        // When
        double result = _calculator.Add(numbers);

        // Then
        Assert.AreEqual(5, result);
    }

    [Test]
    public void Given_Three_Arguments_When_Adding_Then_Returns_The_Sum()
    {
        // Given
        double[] numbers = new double[] { 2, 3, 4 };

        // When
        double result = _calculator.Add(numbers);

        // Then
        Assert.AreEqual(9, result);
    }
    
    [Test]
    public void Given_No_Arguments_When_Subtracting_Then_Returns_Zero()
    {
        // Given
        double[] numbers = new double[0];

        // When
        double result = _calculator.Subtract(numbers);

        // Then
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Given_One_Argument_When_Subtracting_Then_Returns_Negative_Of_That_Number()
    {
        // Given
        double[] numbers = new double[] { 3 };

        // When
        double result = _calculator.Subtract(numbers);

        // Then
        Assert.AreEqual(3, result);
    }

    [Test]
    public void Given_Two_Arguments_When_Subtracting_Then_Returns_The_Difference()
    {
        // Given
        double[] numbers = new double[] { 5, 2 };

        // When
        double result = _calculator.Subtract(numbers);

        // Then
        Assert.AreEqual(3, result);
    }

    [Test]
    public void Given_Three_Arguments_When_Subtracting_Then_Returns_The_Difference()
    {
        // Given
        double[] numbers = new double[] { 8, 3, 1 };

        // When
        double result = _calculator.Subtract(numbers);

        // Then
        Assert.AreEqual(4, result);
    }
    
    [Test]
    public void Given_No_Arguments_When_Multiplying_Then_Returns_One()
    {
        // Given
        double[] numbers = new double[0];

        // When
        double result = _calculator.Multiply(numbers);

        // Then
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Given_One_Argument_When_Multiplying_Then_Returns_That_Number()
    {
        // Given
        double[] numbers = new double[] { 3 };

        // When
        double result = _calculator.Multiply(numbers);

        // Then
        Assert.AreEqual(3, result);
    }

    [Test]
    public void Given_Two_Arguments_When_Multiplying_Then_Returns_The_Product()
    {
        // Given
        double[] numbers = new double[] { 5, 2 };

        // When
        double result = _calculator.Multiply(numbers);

        // Then
        Assert.AreEqual(10, result);
    }

    [Test]
    public void Given_Three_Arguments_When_Multiplying_Then_Returns_The_Product()
    {
        // Given
        double[] numbers = new double[] { 2, 3, 4 };

        // When
        double result = _calculator.Multiply(numbers);

        // Then
        Assert.AreEqual(24, result);
    }
    
    [Test]
    public void Given_No_Arguments_When_Dividing_Then_Throws_DivideByZeroException()
    {
        // Given
        double[] numbers = new double[0];

        // When
        double result = _calculator.Divide(numbers);

        // Then
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Given_One_Argument_When_Dividing_Then_Returns_That_Number()
    {
        // Given
        double[] numbers = new double[] { 3 };

        // When
        double result = _calculator.Divide(numbers);

        // Then
        Assert.AreEqual(3, result);
    }

    [Test]
    public void Given_Two_Arguments_When_Dividing_Then_Returns_The_Quotient()
    {
        // Given
        double[] numbers = new double[] { 10, 2 };

        // When
        double result = _calculator.Divide(numbers);

        // Then
        Assert.AreEqual(5, result);
    }

    [Test]
    public void Given_Three_Arguments_When_Dividing_Then_Returns_The_Quotient_Of_First_Two_Arguments()
    {
        // Given
        double[] numbers = new double[] { 24, 3, 2 };

        // When
        double result = _calculator.Divide(numbers);

        // Then
        Assert.AreEqual(4, result);
    }

    [Test]
    public void Given_First_Argument_Is_Zero_When_Dividing_Then_Throws_NullReferenceException()
    {
        // Given
        double[] numbers = new double[] { 0, 2 };

        // When, Then
        Assert.Throws<NullReferenceException>(() => _calculator.Divide(numbers));
    }
}