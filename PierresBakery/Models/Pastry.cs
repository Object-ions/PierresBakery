using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public static int pastryPrice = 2;
    public static int discountEvery = 4;
    public static int CalcCost(int userInput)
    {
      int pastriesToPay = userInput - (userInput / discountEvery);
      int costOfPastry = pastryPrice * pastriesToPay;

      return costOfPastry;
    }
  }
}