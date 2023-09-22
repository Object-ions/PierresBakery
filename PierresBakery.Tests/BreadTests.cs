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
    public void CalcCost_CalcCostOfBreadLoaves_int()
    {
      // Arrange
      int userInput = 1;
      // Act
      int expectedReturn = Bread.CalcCost(userInput);
      // Assert
      Assert.AreEqual(5, expectedReturn);
    }
  }
}
