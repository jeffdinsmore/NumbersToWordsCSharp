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
      string number = "1";
      int input = int.Parse(number);
      Assert.AreEqual("one", testOnes.OneThruNineteen(input));
    }

    [TestMethod]
    public void TranslateTens_TakeNumberAndTurnIntoWrittenNumber_WrittenNumber()
    {
      Translate testTens = new Translate();
      string number = "20";
      Assert.AreEqual("twenty", testTens.TensAfterNineteen(number));
    }
    [TestMethod]
    public void TranslateHundreds_TakeNumberAndTurnIntoWrittenNumber_WrittenNumber()
    {
      Translate testHundreds = new Translate();
      string number = "300";
      Assert.AreEqual("three hundred", testHundreds.OneHundreds(number));
    }
  }
}