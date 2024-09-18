using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount of money in cents to convert to coins:");
      string userInput = Console.ReadLine();      
      
      double cents = Convert.ToDouble(userInput);

      //if user enters decimal amount of cents
      cents = Math.Floor(cents);

      Console.WriteLine(userInput + " cents is equal to...");

      int goldCoin = 10;
      int silverCoin = 5;

      double goldCoins = Math.Floor(cents/goldCoin);
      double remainder = cents%goldCoin;

      double silverCoins = Math.Floor(remainder/silverCoin);
      remainder = remainder%silverCoin;

      Console.WriteLine("Gold coins: "+goldCoins);
      Console.WriteLine("Silver coins: "+silverCoins);
      Console.WriteLine("Bronze coins: "+remainder);
    }
  }
}