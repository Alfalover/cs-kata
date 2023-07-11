namespace FizzBuzzKata;

using Xunit;
using FluentAssertions;
using System;

public class FizzBuzzShould
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(4, "4")]
    public void ReturnNumberAsStringWhenInputIsNotMultipleOfThreeFiveOrBoth(int number, string expected)
    {
        FizzBuzz.compute(number).Should().Be(expected);
    }

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    public void ReturnFizzWhenInputIsMultipleOfThree(int number)
    {
        FizzBuzz.compute(number).Should().Be("Fizz");
    }

    [Fact]
    public void ReturnBuzzWhenInputIsFive()
    {
        FizzBuzz.compute(5).Should().Be("Buzz");
    }
}

internal class FizzBuzz
{
    internal static string compute(int number)
    {
        if (number % 3 == 0)
        {
            return "Fizz";
        }

        if (number == 5)
        {
            return "Buzz";
        }

        return number.ToString();
    }
}