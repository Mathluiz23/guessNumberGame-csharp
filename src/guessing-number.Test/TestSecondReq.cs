using Xunit;
using System.IO;
using System;
using Moq;
using guessing_number;
using FluentAssertions;

namespace guessing_number.Test;

[Collection("Sequential")]
public class TestSecondReq
{
  [Theory(DisplayName = "Deve escolher randomicamente um número entre -100 e 100!")]
  [InlineData(-100, 100)]
  public void TestRandomlyChooseANumber(int MinimumRange, int MaximumRange)
  {
    var guessNumber = new GuessNumber();

    guessNumber.RandomNumber();

    guessNumber.randomValue.Should().BeGreaterThan(MinimumRange).And.BeLessThan(MaximumRange);
  }

  [Theory(DisplayName = "Deve comparar a entrada do usuário em um caso MENOR")]
  [InlineData(50, 0)]
  public void TestProgramComparisonValuesLess(int mockValue, int entry)
  {
    var guessNumber = new GuessNumber();

    guessNumber.randomValue = mockValue;

    entry.Should().BeLessThan(guessNumber.randomValue);
  }
  [Theory(DisplayName = "Deve comparar a entrada do usuário em um caso MAIOR")]
  [InlineData(50, 60)]
  public void TestProgramComparisonValuesBigger(int mockValue, int entry)
  {
    var guessNumber = new GuessNumber();

    guessNumber.randomValue = mockValue;

    entry.Should().BeGreaterThan(guessNumber.randomValue);
  }

  [Theory(DisplayName = "Deve comparar a entrada do usuário em um caso MAIOR")]
  [InlineData(50, 50)]
  public void TestProgramComparisonValuesEqual(int mockValue, int entry)
  {
    var guessNumber = new GuessNumber();

    guessNumber.randomValue = mockValue;

    entry.Should().Be(guessNumber.randomValue);
  }
}