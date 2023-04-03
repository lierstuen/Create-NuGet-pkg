namespace MathHelper.Interfaces;

public interface ICalculator
{
    double Add(params double[] numbers);
    double Subtract(params double[] numbers);
    double Multiply(params double[] numbers);
    double Divide(params double[] numbers);
}