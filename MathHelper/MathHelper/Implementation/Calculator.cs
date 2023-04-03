using MathHelper.Interfaces;

namespace MathHelper.Implementation;

public class Calculator : ICalculator
{
    public double Add(params double[] numbers)
    {
        if (numbers.Length == 0)
        {
            return 0;
        }
        
        double sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }

        return sum;
    }

    public double Subtract(params double[] numbers)
    {
        if (numbers.Length == 0)
        {
            return 0;
        }

        var difference = numbers[0];
        foreach (var num in numbers?.Skip(1) ?? Array.Empty<double>())
        {
            difference -= num;
        }

        return difference;
    }

    public double Multiply(params double[] numbers)
    {
        if (numbers.Length == 0)
        {
            return 0;
        }

        var product = numbers[0];
        foreach (var num in numbers?.Skip(1) ?? Array.Empty<double>())
        {
            product *= num;
        }

        return product;
    }

    public double Divide(params double[] numbers)
    {
        if (numbers.Length == 0)
        {
            return 0;
        }

        var quotient = numbers[0];
        foreach (var num in numbers?.Skip(1) ?? Array.Empty<double>())
        {
            if (quotient == 0)
            {
                throw new NullReferenceException();
            }

            quotient /= num;
        }

        return quotient;
    }
}