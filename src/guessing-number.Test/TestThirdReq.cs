using Xunit;
using System.IO;
using System;
using Moq;
using guessing_number;
using FluentAssertions;

namespace guessing_number.Test;

[Collection("Sequential")]
public class TestThirdReq
{
  [Theory(DisplayName = "Deve receber a executar o fluxo completo do programa")]
  [InlineData(new object[] { new string[] { "10" }, 10 })]
  public void TestFullFlow(string[] entrys, int mockValue)
  {
    if (Convert.ToInt32(entrys[entrys.Length - 1]) != mockValue) throw new System.OutOfMemoryException();

    using (var stringWriter = new StringWriter())
    {
      using (var stringReader = new StringReader(String.Join("\n", entrys)))
      {
        Console.SetIn(stringReader);
        Console.SetOut(stringWriter);

        var guessNumber = new GuessNumber();
        guessNumber.Greet();
        guessNumber.ChooseNumber();
        guessNumber.randomValue = mockValue;
        guessNumber.AnalyzePlay();


        var response = stringWriter.ToString().Trim().Split("\n");

        if (guessNumber.randomValue < guessNumber.userValue) response[response.Length - 1].Should().Be("Tente um número MENOR");
        else if (guessNumber.randomValue > guessNumber.userValue) response[response.Length - 1].Should().Be("Tente um número MAIOR");
        else response[response.Length - 1].Should().Be("ACERTOU!");

      }
    }
  }
}