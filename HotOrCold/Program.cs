// See https://aka.ms/new-console-template for more information
using System;

	namespace HotOrCold
	{
		public class HOC
		{

			public static void Main(string[] args) 
			{
					Console.WriteLine("Hot or Cold Guessing Game!");
					var rand = new Random();
					int target = rand.Next(21); //generate a random number between 0 - 20

					//*************************************
					Console.WriteLine(target);
					//*************************************

//-------------------------------------------------------------------------------------------------------------------
				bool loop = true;

				while(loop)
				{
					Console.WriteLine("Guess a number between 0 and 20");
					int guess = Int32.Parse(Console.ReadLine());
					
					if (guess == target)
					{
						Console.WriteLine("You Win");
						loop = false;
					}
					else if (guess > target)
					{
						Console.WriteLine("Oops! Your Guess was too high!");
					}
					else
					{
						Console.WriteLine("Oops! Your Guess was too low!");
					}
				}
//--------------------------------------------------------------------------------------------------------------------
			}

		}

	}
