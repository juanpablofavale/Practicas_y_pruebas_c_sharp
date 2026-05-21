//using System;

Console.WriteLine("Creación del primer método.");

/* 
--Unidad 3
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
--Unidad 4
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

/*
//Unidad 5
//string ipv4Input = "107.31.1.5";
string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] ip;

foreach (string ipv4 in ipv4Input)
{
	ip = ipv4.Split(".", StringSplitOptions.RemoveEmptyEntries);

	if (ValidateLength() && ValidateZeroes() && ValidateRange()) 
	{
		Console.WriteLine($"ip {ipv4} is a valid IPv4 address");
	} 
	else 
	{
		Console.WriteLine($"ip {ipv4} is an invalid IPv4 address");
	}
}

bool ValidateLength()
{
	return ip.Length==4; 
}

bool ValidateZeroes()
{

	foreach (string num in ip)
	{
		if (num.Length > 1 && num.StartsWith("0"))
		{
			return false;
		}
	}
	
	return true;
}

bool ValidateRange()
{
	
	foreach (string num in ip)
	{
		//int valor;
		int.TryParse(num, out int valor);
		if ( valor < 0 || valor > 255)
		{
			return false;
		}
	}
	
	return true;
}
*/

//Unidad 6
Random random = new Random();

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

int luck = random.Next(100);
TellFortune();

luck = random.Next(100);
TellFortune();


void TellFortune()
{
	
	Console.WriteLine("A fortune teller whispers the following words:");
	string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
	for (int i = 0; i < 4; i++) 
	{
		Console.Write($"{text[i]} {fortune[i]} ");
	}
	Console.WriteLine("\n");
}

