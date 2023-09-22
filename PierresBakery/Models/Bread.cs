using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public static int breadPrice = 5;
    public static int discountEvery = 3;
    public static int CalcCost(int userInput)
    {
      int loavesToPay = userInput - (userInput / discountEvery);
      int costOfBread = breadPrice * loavesToPay;

      return costOfBread;
    }
  }
}

