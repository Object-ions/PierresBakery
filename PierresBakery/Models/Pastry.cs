using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public static int PastryPrice { get; set; } = 2;
    public static int DiscountEvery { get; set; } = 4;
    public static int CalcCost(int userInput)
    {
      int pastriesToPay = userInput - (userInput / DiscountEvery);
      int costOfPastry = PastryPrice * pastriesToPay;

      return costOfPastry;
    }
  }
}