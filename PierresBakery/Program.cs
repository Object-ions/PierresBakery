using System;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {

      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("");
      Console.WriteLine("We are offering a * SPECIAL DEAL * over loaves of bread and pastries");
      Console.WriteLine("a Loaf of bread is 5$ a piece OR buy 2 loaves and get 1 *free*");
      Console.WriteLine("a Pasty is 2$ a piece OR buy 3 pieces of pastry and get 1 *free*");
      Console.WriteLine("");

      Console.WriteLine("How many loaves of bread would you like to get?");
      string breadUserInput = Console.ReadLine();
      int breadUserNumber = int.Parse(breadUserInput);
      int costOfBread = Bread.CalcCost(breadUserNumber);

      Console.WriteLine("How many pastries would you like to get?");
      string pastryUserInput = Console.ReadLine();
      int pastryUserNumber = int.Parse(pastryUserInput);
      int costOfPastry = Pastry.CalcCost(pastryUserNumber);

      int totalCost = costOfBread + costOfPastry;

      Console.WriteLine("");
      Console.WriteLine($"The cost of {breadUserNumber} loaves of bread are : ${costOfBread}");
      Console.WriteLine($"The cost of {pastryUserNumber} pieces of pastry : ${costOfPastry}");
      Console.WriteLine("");
      Console.WriteLine($"That's a total of: ${totalCost}");
      Console.WriteLine("");
      Console.WriteLine("");

      Console.WriteLine("We appriciate your buisness");
      Console.WriteLine("and looking forward to see you here again!");
      Console.WriteLine("");
      Console.WriteLine("");

    }
  }

}