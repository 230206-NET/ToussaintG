// See https://aka.ms/new-console-template for more information

using System;

namespace CoinFlipper
{
	public class Flipper
	{

		public static void Main(String[] args)
		{
			Console.WriteLine("Coin Flipper starting....");
			
			var rand = new Random();
			int value = rand.Next();
			
			
			Console.WriteLine("This is a Random Number: " + rand.Next());
			
			bool coin = true;

			int remainder = value % 2;

			if (remainder == 0)
			{
				coin = false;
			}

			if(coin)
			{
				Console.WriteLine("Your coin was flipped, it was heads");
			
			}
			else 
			{
				Console.WriteLine("Your coin was flipped, it was tails");
			}
			
			
			
			
			
			
			
		}
	}
}
