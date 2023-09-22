using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public static int breadPrice = 5;
    public static int CalcCost(int userInput)
    {
      int costOfBread = 0;
      if (userInput % 3 == 0)
      {
        // special price
        int loavesToPay = userInput - (userInput / 3);
        costOfBread = breadPrice * loavesToPay;
      }
      else
      {
        // regular price
        costOfBread = breadPrice * userInput;
      }

      return costOfBread;
    }
  }
}

