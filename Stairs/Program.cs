using System;

namespace Stairs
{
	class Stairs
	{
		private const string _inputError = "Please provide a positive integer for the number of stairs.  Ex. Stairs.exe 14";

		/// <summary>
		/// Program entry point.
		/// </summary>
		/// <param name="args">A number representing the number of stair steps.</param>
		static void Main(string[] args)
		{
			try
			{
				if (args.Length > 0 && !string.IsNullOrEmpty(args[0]))
				{
					int numStairs;
					if (int.TryParse(args[0], out numStairs))
					{
						if (numStairs > 0)
						{
							Console.WriteLine($"There are {CalculateWays(numStairs)} combinations of 1 or 2 steps for {numStairs} stairs.");
						}
						else
						{
							Console.WriteLine(_inputError);
						}
					}
					else
					{
						Console.WriteLine(_inputError);
					}
				}
				else
				{
					Console.WriteLine(_inputError);
				}
			}
			catch (Exception)
			{
				Console.WriteLine($"An unexpected error has occurred.  {_inputError}");
			}
		}

		/// <summary>
		/// Calculates the number of permutations possible.
		/// </summary>
		/// <param name="stairs">The total number of stairs to climb.</param>
		/// <returns>An integer representing the total number of permutations for 1 or 2 steps.</returns>
		private static int CalculateWays(int stairsRemaining)
		{
			if (stairsRemaining < 2)
				return 1;

			int endWithOneStep = CalculateWays(stairsRemaining - 1);
			int endWithTwoStep = CalculateWays(stairsRemaining - 2);

			return endWithOneStep + endWithTwoStep;
		}

	}
}
