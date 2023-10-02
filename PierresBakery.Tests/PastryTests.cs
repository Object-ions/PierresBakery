using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void CalcCost_ReturnsDataType_Int()
    {
      int userInput = 1;
      var result = Pastry.CalcCost(userInput);
      Assert.IsInstanceOfType(result, typeof(int));
    }

    [TestMethod]
    public void CalcCost_CalcCostOfPastry_1Pastries_int()
    {
      int userInput = 1;
      int expectedReturn = Pastry.CalcCost(userInput);
      Assert.AreEqual(2, expectedReturn);
    }

    [TestMethod]
    public void CalcCost_CalcCostOfPastry_7Pastries_int()
    {
      int userInput = 7;
      int expectedReturn = Pastry.CalcCost(userInput);
      Assert.AreEqual(12, expectedReturn);
    }

    [TestMethod]
    public void CalcCost_CalcCostOfPastry_8Pastries_int()
    {
      int userInput = 8;
      int expectedReturn = Pastry.CalcCost(userInput);
      Assert.AreEqual(12, expectedReturn);
    }
  }
}
