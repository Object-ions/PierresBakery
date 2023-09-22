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
    public void CalcCost_CalcCostOfBreadLoaves_int(int amountOfLoaves)
    {
      // Arrange
      int userInput = 1;
      // Act
      int returnedNumber = Bread.NumberTest(userInput);
      // Assert
      Assert.AreEqual(2, returnedNumber);
    }
  }
}
