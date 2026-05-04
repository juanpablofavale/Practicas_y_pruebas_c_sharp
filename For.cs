Console.WriteLine("Ciclo For\n");

/*
for (int i = 10; i > 0; i--)
{
	Console.WriteLine($"{i}");
	if (i == 7) break;
}
*/

/*
string[] names = {"Alex", "Eddie", "David", "Michael"};
for (int i = names.Length - 1; i >= 0; i--)
{
	Console.WriteLine($"{i} - {names[i]}");
}
*/

/*
string[] names = {"Alex", "Eddie", "David", "Michael"};
for (int i = 0; i < names.Length; i++)
{
	if (names[i] == "David") names[i] = "Sammy";
}

foreach (string name in names) Console.WriteLine(name);
*/

for (int i = 1; i <= 100; i++)
{
/* codigo original -- en lo posible siempre buscar la forma de no usar if anidados
	if (i % 3 == 0) 
	{
		if (i % 5 == 0)
		{
			Console.WriteLine($"{i} - FizzBuzz");
		}
		else
		{
			Console.WriteLine($"{i} - Fizz");
		}
	}
	else
	{
		if (i % 5 == 0)
		{
			Console.WriteLine($"{i} - Buzz");
		}
		else
		{
			Console.WriteLine($"{i}");
		}
	}
*/

	if ((i % 3 == 0) && (i % 5 == 0))
		Console.WriteLine($"{i} - FizzBuzz");
	else if (i % 3 == 0)
		Console.WriteLine($"{i} - Fizz");
	else if (i % 5 == 0)
		Console.WriteLine($"{i} - Buzz");
	else
		Console.WriteLine($"{i}");
}
