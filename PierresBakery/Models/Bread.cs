using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public static int BreadPrice { get; set; } = 5;
    public static int DiscountEvery { get; set; } = 3;
    public static int CalcCost(int userInput)
    {
      int loavesToPay = userInput - (userInput / DiscountEvery);
      int costOfBread = BreadPrice * loavesToPay;

      return costOfBread;
    }
  }
}

