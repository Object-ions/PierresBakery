using System;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {

      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("");
      Console.WriteLine("We are offering a * special deal * over loaves of bread and pastries");
      Console.WriteLine("a Loaf of bread is 5$ a pice OR buy 2 get 1 *free*");
      Console.WriteLine("a Pasty is 2$ a pice OR buy 3 get 1 *free*");
      Console.WriteLine("");

      Console.WriteLine("How many loaves of bread would you like to get?");
      string breadUserInput = Console.ReadLine();
      int breadUserNumber = int.Parse(breadUserInput);

      Console.WriteLine("How many pastries would you like to get?");
      string pastryUserInput = Console.ReadLine();
      int pastryUserNumber = int.Parse(pastryUserInput);

      Console.WriteLine("");
      Console.WriteLine($"The cost of {userInput} is : {result}");
      Console.WriteLine("");


      Console.WriteLine("done!");

    }
  }

}