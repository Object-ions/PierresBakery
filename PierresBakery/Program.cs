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
      Console.WriteLine("Welcome to");
      Console.WriteLine(@"
        _____    _                               _           ____            _                          
      |  __ \  (_)                             ( )         |  _ \          | |                         
      | |__) |  _    ___   _ __   _ __    ___  |/   ___    | |_) |   __ _  | | __   ___   _ __   _   _ 
      |  ___/  | |  / _ \ | '__| | '__|  / _ \     / __|   |  _ <   / _` | | |/ /  / _ \ | '__| | | | |
      | |      | | |  __/ | |    | |    |  __/     \__ \   | |_) | | (_| | |   <  |  __/ | |    | |_| |
      |_|      |_|  \___| |_|    |_|     \___|     |___/   |____/   \__,_| |_|\_\  \___| |_|     \__, |
                                                                                                  __/ |
                                                                                                  |___/ 
      ");
      Console.WriteLine("We are offering a * SPECIAL DEAL * over loaves of bread and pastries");
      Console.WriteLine($"a Loaf of bread is ${Bread.BreadPrice} a piece OR buy 2 loaves and get 1 *free*");
      Console.WriteLine($"a Pasty is ${Pastry.PastryPrice} a piece OR buy 3 pieces of pastry and get 1 *free*");
      Console.WriteLine("");


      PlaceOrder();
      Console.WriteLine($"Now let's confirm your order");
      OrderStatus();

      Console.WriteLine("We appriciate your buisness");
      Console.WriteLine("and looking forward to seeing you here again!");
      Console.WriteLine("Bon Apetit!");
      Console.WriteLine("");


      public static void PlaceOrder()
      {
        Console.WriteLine("How many loaves of bread would you like to get?");
        string breadUserInput = Console.ReadLine();
        int breadUserNumber = int.Parse(breadUserInput);
        int costOfBread = Bread.CalcCost(breadUserNumber);

        Console.WriteLine("How many pastries would you like to get?");
        string pastryUserInput = Console.ReadLine();
        int pastryUserNumber = int.Parse(pastryUserInput);
        int costOfPastry = Pastry.CalcCost(pastryUserNumber);

        int totalCost = costOfBread + costOfPastry;

        Console.WriteLine($"The cost of {breadUserNumber} loaves of bread is: ${costOfBread}");
        Console.WriteLine($"The cost of {pastryUserNumber} pastries is: ${costOfPastry}");
        Console.WriteLine($"Total cost is: ${totalCost}");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
      }

      public static void OrderStatus()
      {
        Console.WriteLine("Please confirm the order by typing 'confirm'");
        Console.WriteLine("or adjust the order by typing 'adjust'");
        string confirmInput = Console.ReadLine();
        if (confirmInput == "confirm")
        {
          Console.WriteLine($"That's a total cost of: ${totalCost}");
          Console.WriteLine($"Your order number is: {GenerateOrderNumber()}");
          Console.WriteLine("Please check out with the cashier");
        }
        else if (confirmInput == "adjust")
        {
          Console.WriteLine("Let's make adjust your order!");
          PlaceOrder();
        }
        else
        {
          Console.WriteLine("You typed and invalid answer, let's try again...");
          OrderStatus()
        }
      }

      public static int GenerateOrderNumber()
      {
        return (int)(new Random().NextDouble() * 900000) + 100000;
      }
    }
  }

}