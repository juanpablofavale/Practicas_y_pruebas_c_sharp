Console.WriteLine("Métodos con devolución");
Console.WriteLine("------- --- ----------");

void UnidadDos()
{
	double total = 0;
	double minimumSpend = 30.00;
	
	double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
	double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};
	
	for (int i = 0; i < items.Length; i++)
	{
		total += GetDiscountedPrice(i);
	}
	
	if (TotalMeetsMinimum())
	{
		total -= 5.00;
	}
	
	Console.WriteLine($"Total: ${FormatDecimal(total)}");
	
	double GetDiscountedPrice(int itemIndex)
	{
		double result = items[itemIndex] * (1 - discounts[itemIndex]);
		return result;
		//igual que lo siguiente
		//return items[itemIndex] * (1 - discounts[itemIndex]);
	}
	
	bool TotalMeetsMinimum()
	{
		return total >= minimumSpend;
	}
	
	string FormatDecimal(double input)
	{
		return input.ToString().Substring(0, 5);
	}
}

Console.WriteLine("\n\nUnidad Dos");
Console.WriteLine("------ ---\n");
UnidadDos();


void UnidadTres()
{
	double usd = 23.73;
	int vnd = UsdToVnd(usd);
	
	Console.WriteLine($"${usd} USD = ${vnd} VND");
	Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");
	
	int UsdToVnd(double usd)
	{
		int rate = 23500;
		return (int) (rate * usd);
	}
	
	double VndToUsd(int vnd)
	{
		double rate = 23500;
		return vnd / rate;
	}
}

Console.WriteLine("\n\nUnidad Tres");
Console.WriteLine("------ ----\n");
UnidadTres();


void UnidadCuatro()
{
	Console.WriteLine($"\nInvertir una palabra\n");
	string input = "snake";
	Console.WriteLine($"{input}");
	Console.WriteLine($"{ReverseWord(input)}");
	
	Console.WriteLine($"\nInvertir las palabras en una frase:\n");
	
	string sentence = "there are snakes at the zoo";
	Console.WriteLine(sentence);
	Console.WriteLine(ReverseSentence(sentence));
	
	string ReverseSentence(string sentence)
	{
		string result = "";
		string[] words = sentence.Split(" ");
		foreach (string word in words)
		{
			result += ReverseWord(word) + " ";
		}
		return result;
	}
	
	string ReverseWord(string word)
	{
		string result = "";
		for (int i = word.Length - 1; i >= 0; i--)
		{
			result += word[i];
		}
		return result.Trim();
	}
}

Console.WriteLine("\n\nUnidad Cuatro");
Console.WriteLine("------ ------\n");
UnidadCuatro();

void UnidadCinco()
{
	string[] words = {"racecar", "talented", "deified", "tent", "tenet"};
	
	Console.WriteLine("Is it a palindrome?");
	foreach (string word in words)
	{
		Console.WriteLine($"{word}: {IsPalindrome(word)}");
	}
	
	bool IsPalindrome(string word)
	{
		int start = 0;
		int end = word.Length - 1;
		
		while (start < end)
		{
			if (word[start] != word[end])
			{
				return false;
			}
			start++;
			end--;
		}
		
		return true;
	}
}

Console.WriteLine("\n\nUnidad Cinco");
Console.WriteLine("------ -----\n");
UnidadCinco();

void UnidadSeis()
{
	int target = 30;
	int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
	int[,] result = TwoCoins(coins, target);
	if (result.Length == 0)
	{
		Console.WriteLine($"No two coins make change");
	}
	else
	{
		Console.WriteLine($"Change found at positions:");
		for (int i = 0; i < result.GetLength(0); i++)
		{
			if (result[i, 0] == -1)
			{
				break;
			}
			Console.WriteLine($"{result[i,0]} and {result[i,1]}");
		}
	}
	
	
	int[,] TwoCoins(int[] coins, int target)
	{
		int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
		int count = 0;
		
		for (int curr = 0; curr < coins.Length; curr++)
		{
			for (int next = curr + 1; next < coins.Length; next++)
			{
				if (coins[curr] + coins[next] == target)
				{
					result[count, 0] = curr;
					result[count, 1] = next;
					count++;
				}
				if (count == result.GetLength(0))
				{
					return result;
				}
			}
		}
		
		if (count == 0)
		{
			return new int[0,0];
		}
		
		return result;
	}
}

Console.WriteLine("\n\nUnidad Seis");
Console.WriteLine("------ ----\n");
UnidadSeis();

void UnidadSiete()
{
	Console.WriteLine("Mini game");
	
	Random rnd = new Random();
	
	Console.WriteLine("Would you like to play= (Y/N)");
	if (ShouldPlay())
	{
		PlayGame(); 
	}
	
	void PlayGame()
	{
		var play = true;
		
		while (play)
		{
			int target = (int) rnd.Next(1,6);
			int roll = (int) rnd.Next(1,7);
			
			Console.WriteLine($"Roll a number greater than {target} to win!");
			Console.WriteLine($"You rolled a {roll}");
			Console.WriteLine($"{WinOrLose()}");
			Console.WriteLine($"\nPlay again? (Y/N)");
			
			play = ShouldPlay();
			
			string WinOrLose()
			{
				return target < roll ? "You win!" : "You lose!";
			}
		}		
	}
	
	bool ShouldPlay()
	{
		string rta = Console.ReadLine();
		return rta.ToLower().Equals("y");
	}
}

Console.WriteLine("\n\nUnidad Siete");
Console.WriteLine("------ -----\n");
UnidadSiete();