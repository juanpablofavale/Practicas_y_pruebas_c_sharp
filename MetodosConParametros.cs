Console.WriteLine("Métodos con parámetros");

void UnidadDos()
{
	int[] schedule = {800, 1200, 1600, 2000};

	void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
	{
		int diff = 0;
		if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
		{
			Console.WriteLine("Invalid GMT");
		}
		else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >=0)
		{
			diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
		}
		else
		{
			diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
		}
		for (int i = 0; i < times.Length; i++)
		{
			int newTime = (times[i] + diff) % 2400;
			Console.WriteLine($"{times[i]} -> {newTime}");
		}
	}

	DisplayAdjustedTimes(schedule, 6, -6);
}

Console.WriteLine("\n\nUnidad Dos\n------ ---");
UnidadDos();

void UnidadTres()
{
	Console.WriteLine("\nStudents");
	string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};
	
	DisplayStudents(students);
	DisplayStudents(new string[] {"Robert","Vanya"});
	
	void DisplayStudents(string[] students)
	{
		foreach (string student in students)
		{
			Console.Write($"{student}, ");
		}
		Console.WriteLine();
	}
	
	Console.WriteLine("\nCircle Area");
	
	double pi = 3.14159;
	PrintCircleInfo(12);
	PrintCircleInfo(24);
	
	void PrintCircleInfo(int radius)
	{
		Console.WriteLine($"\nCircle with radius {radius}");
		PrintCircleArea(radius);
		PrintCircleCircumference(radius);		
	}
	
	void PrintCircleArea(int radius)
	{
		double area = pi * (radius * radius);
		Console.WriteLine($"Area: {area}");
	}
	
	void PrintCircleCircumference(int radius)
	{
		double circumference = 2 * pi * radius;
		Console.WriteLine($"Cirfumference: {circumference}");
	}
}

Console.WriteLine("\n\nUnidad Tres\n------ ----");
UnidadTres();

void UnidadCuatro()
{
	void PorValor()
	{
		int a = 3;
		int b = 4;
		int c = 0;
		
		Multiply(a, b, c);
		Console.WriteLine($"global statement: {a} x {b} = {c}");
		
		void Multiply(int a, int b, int c)
		{
			c = a * b;
			Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
		}
	}
	
	Console.WriteLine("\nPor Valor");
	PorValor();
	
	void PorReferencia()
	{
		int[] array = {1, 2, 3, 4, 5};
		
		PrintArray(array);
		Clear(array);
		PrintArray(array);
		
		void PrintArray(int[] array)
		{
			foreach (int item in array)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();
		}
		
		void Clear(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = 0;
			}
		}
	}
	
	Console.WriteLine("\nPor Referencia");
	PorReferencia();
	
	void ConCadenas()
	{
		string status = "Healthy";
		
		Console.WriteLine($"Start: {status}");
		SetHealth(false);
		Console.WriteLine($"End: {status}");
		
		void SetHealth(bool isHealthy)
		{
			status = (isHealthy ? "Healthy" : "Unhealthy");
			Console.WriteLine($"Middle: {status}");
		}
	}
	
	Console.WriteLine("\nCon Cadenas");
	ConCadenas();

}

Console.WriteLine("\n\nUnidad Cuatro\n------ ------");
UnidadCuatro();

void UnidadCinco()
{
	//seguir aca con la unidad 5
	string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
	string[] rsvps = new string[10];
	int count = 0;
	
	//void RSVP(string name, int partySize, string allergies, bool inviteOnly)
	//Para parametros opcionales se asigna un valor por defecto
	void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
	{
		if (inviteOnly)
		{
			bool found = false;
			foreach (string guest in guestList)
			{
				if (guest.Equals(name))
				{
					found = true;
					break;
				}
			}
			if (!found)
			{
				Console.WriteLine($"Sorry, {name} is not on the guest list");
				return;
			}
		}
		
		rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
		count++;
	}
	
	void ShowRSVPs()
	{
		Console.WriteLine($"\nTotal RSVPs:");
		for (int i = 0; i < count; i++)
		{
			Console.WriteLine(rsvps[i]);
		}
	}
	
	RSVP("Rebecca", 1, "none", true);
	RSVP("Nadia", 2, "Nuts", true);
	//Elementos posicionales (se organizan según posicion)
	//RSVP("Linh", 2, "none", false);
	//Llamar método con argumentos por nombre para mejorar legibilidad
	//Si no hay elementos posicionales no deben respetar orden alguno
	RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
	//RSVP("Tony", 1, "Jackfruit", true);
	//Si se pasa algún elemento posicional se debe respetar la posicion
	RSVP("Tony", inviteOnly: true, allergies: "Jackfruit",  partySize: 1);
	RSVP("Noor", 4, "none", false);
	RSVP("Jonte", 2, "Stone fruit", false);
	ShowRSVPs();
	
	/*
	//Ejemplo de uso de los parámetros opcionales
	RSVP("Rebecca");
	RSVP("Nadia", 2, "Nuts");
	RSVP(name: "Linh", partySize: 2, inviteOnly: false);
	RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
	RSVP("Noor", 4, inviteOnly: false);
	RSVP("Jonte", 2, "Stone fruit", false);
	ShowRSVPs();
	*/
}

Console.WriteLine("\n\nUnidad Cinco\n------ -----\n");
UnidadCinco();

/*

*/

void UnidadSeis()
{
	string[,] corporate = 
	{
		{"Robert", "Bavin"}, {"Simon", "Bright"},
		{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
		{"Sarah", "Delucchi"}, {"Sinan", "Ali"}
	};

	string[,] external = 
	{
		{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
		{"Shay", "Lawrence"}, {"Daren", "Valdes"}
	};

	ShowEmails(corporate);
	string externalDomain = "hayworth.com";
	ShowEmails(external, externalDomain);

	void ShowEmails(string[,] userList, string domain = "contoso.com")
	{		
		for (int i = 0; i < userList.GetLength(0); i++) 
		{
			// display internal email addresses
			string userName = userList[i,0].Substring(0,2).ToLower() + userList[i,1].ToLower();
			Console.WriteLine($"{userName}@{domain}");
		}
	}
}

Console.WriteLine("\n\nUnidad Seis\n------ ----\n");
UnidadSeis();
