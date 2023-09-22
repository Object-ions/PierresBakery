using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public static int breadPrice = 5;
    public static int CalcCost(int userInput)
    {
      int loavesToPay = userInput - (userInput / 3);
      int costOfBread = breadPrice * loavesToPay;

      return costOfBread;
    }
  }
}

