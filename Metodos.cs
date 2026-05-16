//using System;

Console.WriteLine("Creación del primer método.");

/*
void DisplayRandomNumbers()
{
	Random rnd = new Random();
	
	for (int i = 0 ; i < 5 ; i++)
	{
		Console.WriteLine($"{i + 1} - {rnd.Next(1, 100)}");
	}
}

DisplayRandomNumbers();

*/
/*
int[] times = {800, 1200, 1600, 2000};
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");


DisplayMedicineTime();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
	AdjustTime();
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
	AdjustTime();
}

Console.WriteLine("New Medicine Schedule:");

DisplayMedicineTime();

// Format and display medicine times
void DisplayMedicineTime()
{
	foreach (int val in times)
	{
		string time = val.ToString();
		int len = time.Length;

		if (len >= 3)
		{
			time = time.Insert(len - 2, ":");
		}
		else if (len == 2)
		{
			time = time.Insert(0, "0:");
		}
		else
		{
			time = time.Insert(0, "0:0");
		}

		Console.Write($"{time} ");
	}

	Console.WriteLine();	
}

// Adjust the times by adding the difference, keeping the value within 24 hours
void AdjustTime()
{
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}
*/

string ipv4Input = "107.31.1.5";

if (ValidateLength() && ValidateZeroes() && ValidateRange()) 
{
    Console.WriteLine($"ip is a valid IPv4 address");
} 
else 
{
    Console.WriteLine($"ip is an invalid IPv4 address");
}

bool ValidateLength()
{
	string[] arr = ipv4Input.Split(".");
	return arr.Length==4; 
}

bool ValidateZeroes()
{
	string[] numeros = ipv4Input.Split(".");
	bool valido = true;
	
	foreach (string numero in arr)
	{
		if (numero.Length > 1 && numero.StartsWith("0"))
		{
			valido = false;
		}
	}
}

bool ValidateRange()
{
	return true;
}