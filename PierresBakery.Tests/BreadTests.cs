using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{

  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void NumberTest_TestingRun_int()
    {
      // Arrange
      int userInput = 9;
      // Act
      char[] output = ScoreCalculator.WordToCharArray(userInput);
      int testint = ;
      // Assert
      CollectionAssert.AreEqual(testArray, output);
    }
  }
}
