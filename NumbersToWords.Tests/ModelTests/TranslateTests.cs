using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NumbersToWords.Models;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class TranslateTests
  {
    [TestMethod]
    public void TranslateOnes_TakeNumberAndTurnIntoWrittenNumber_WrittenNumber()
    {
      Translate testOnes = new Translate();
      string number = "101";
      Assert.AreEqual("one", testOnes.OneThruNineteen(number));
    }

    [TestMethod]
    public void TranslateTens_TakeNumberAndTurnIntoWrittenNumber_WrittenNumber()
    {
      Translate testTens = new Translate();
      string number = "3245";
      Assert.AreEqual("forty", testTens.TensAfterNineteen(number));
    }
    [TestMethod]
    public void TranslateHundreds_TakeNumberAndTurnIntoWrittenNumber_WrittenNumber()
    {
      Translate testHundreds = new Translate();
      string number = "74300";
      Assert.AreEqual("three hundred", testHundreds.OneHundreds(number));
    }

    [TestMethod]
    public void TranslateOnesAndTens_TakeNumberAndTurnIntoWrittenNumber_WrittenNumber()
    {
      Translate testMultipleTens = new Translate();
      string number = "74";
      Assert.AreEqual("seventy four", (testMultipleTens.TensAfterNineteen(number) + " " + testMultipleTens.OneThruNineteen(number)));
    }

    [TestMethod]
    public void TranslatehundredsOfThousands_TakeNumberAndTurnIntoWrittenNumber_WrittenNumber()
    {
      Translate testHundredsOfThousands = new Translate();
      string number = "926000";
      Assert.AreEqual("nine hundred twenty-six thousand", testHundredsOfThousands.OneThousands(number));
    }

    [TestMethod]
    public void TranslateAllNumbersLessThanAMillion_TakeNumberAndTurnIntoWrittenNumber_WrittenNumber()
    {
      Translate testAllNumbersLessThanAMillion = new Translate();
      string number = "94000";
      Assert.AreEqual("nine hundred twenty-six thousand two hundred thirty-two", (testAllNumbersLessThanAMillion.OneThousands(number) + " " + testAllNumbersLessThanAMillion.OneHundreds(number) + " " + testAllNumbersLessThanAMillion.TensAfterNineteen(number) + " " + testAllNumbersLessThanAMillion.OneThruNineteen(number)));
    }
  }
}