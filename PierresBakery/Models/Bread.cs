using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public static int breadPrice = 5;
    public static int CalcCost(int userInput)
    {
      int costOfBread = breadPrice * userInput;

      return costOfBread;
    }
  }
}

