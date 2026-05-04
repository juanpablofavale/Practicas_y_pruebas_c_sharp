Console.WriteLine("Bucles Do While\n");
/*
Random random = new Random();
int current = 0;
*/
/*
do
{
	current = random.Next(1,11);

	if (current >= 8) continue;

	Console.WriteLine(current);
} while (current != 7);
*/

/*
while (current >= 3)
{
	Console.WriteLine(current);
	current = random.Next(1,11);
}

Console.WriteLine($"El último número fue: {current}");
*/

/*
int saludHeroe = 50, saludMonstruo = 50;

do
{
	current = random.Next(1,11);
	saludMonstruo -= current;
	if (saludMonstruo <= 0) saludMonstruo = 0;
	Console.WriteLine($"El héroe ataca al monstruo con una fuerza de {current}, dejándolo con {saludMonstruo} de vida.");

	if (!(saludMonstruo > 0)) continue;

	current = random.Next(1,11);
	saludHeroe -= current;
	if (saludHeroe <= 0) saludHeroe = 0;
	Console.WriteLine($"El monstruo ataca al héroe con una fuerza de {current}, dejándolo con {saludHeroe} de vida.");

} while ((saludHeroe > 0) && (saludMonstruo > 0));

string ganador = (saludHeroe > 0 ? "Héroe" : "Monstruo");

Console.WriteLine($"\nGanó el {ganador}!!");
*/

/* Ejercicio 1 (tenia mal la condicion del while)
int numero = 0;
bool enteroValido = false;
string? readResult;

do
{
	Console.WriteLine("\nEnter an integer number between 5 and 10:");
	readResult = Console.ReadLine();
	if (readResult != null)	enteroValido = int.TryParse(readResult, out numero);
	if (!enteroValido) Console.WriteLine("You entered an invalid number.");
} while (!enteroValido || numero < 5 || numero > 10);

Console.WriteLine($"El numero ingresado es {numero}");
*/

/* Proyecto 2 - funcional
string? rol = "";
bool rolValido = false;

do
{
	Console.WriteLine("Ingrese el rol del usuario (administrador - director - usuario)");
	rol = Console.ReadLine().ToLower().Trim();
	if (rol == "administrador" || rol == "director" || rol == "usuario")
	{
		rolValido = true;
		Console.WriteLine($"Su entrada ({rol}) para tipo de usuario es válida.");
	}
	else
	{
		Console.WriteLine($"Su entrada ({rol}) no es un tipo de usuario válido.");
	}
} while (!rolValido);
*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

for ( int i = 0 ; i < myStrings.Length ; i++ )
{
	string myString = myStrings[i];
	int periodLocation = 0;
	do
	{
		periodLocation = myString.IndexOf(".");
		if ( periodLocation >= 0 )
		{
			Console.WriteLine($"{myString.TrimStart().Substring(0,periodLocation)}");
		}
		else
		{
			Console.WriteLine($"{myString.TrimStart()}");
		}
		myString = myString.Remove(0, periodLocation + 2 );
	} while (periodLocation >= 0);
}

























