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
      // testing code will go here
      Translate testOnes = new Translate();
      Assert.AreEqual("one", testOnes.Ones(1));
    }
  }
}