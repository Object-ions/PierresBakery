using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public static int PastryPrice { get; set; } = 2;
    public static int discountEvery { get; set; } = 4;
    public static int CalcCost(int userInput)
    {
      int pastriesToPay = userInput - (userInput / discountEvery);
      int costOfPastry = PastryPrice * pastriesToPay;

      return costOfPastry;
    }
  }
}