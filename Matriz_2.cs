Console.WriteLine("Operaciones con Matrices");

/*
string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

/*
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
	Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
	Console.WriteLine($"-- {pallet}");
}
*/
/*
Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
	Console.WriteLine($"-- {pallet}");
}


Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
	Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach(var pallet in pallets)
{
	Console.WriteLine($"-- {pallet}");
}
*/

/*
string value1 = "abc123";
char[] valueArray = value1.ToCharArray();


foreach (var value in valueArray)
{
	Console.WriteLine($"-- Char: {value}");
}

Array.Reverse(valueArray);
//string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(",");
foreach (var item in items)
{
	Console.WriteLine(item);
}
*/

/*
string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(" ");

for (int i = 0 ; i < words.Length ; i++ )
{
	char[] wordArray = words[i].ToCharArray();
	Array.Reverse(wordArray);
	words[i] = new string(wordArray);
}

string result = String.Join(" ", words);

Console.WriteLine(result);
*/

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] codigosArray = orderStream.Split(",");
Array.Sort(codigosArray);

foreach (string codigo in codigosArray)
{
	string mensaje = codigo + ((codigo.Length!=4) ? "\t- Error" : "");
	Console.WriteLine($"{mensaje}");
}

/* Para tener en cuenta
Métodos de Array 
Array.ToCharArray(string) <- Separa un string en un array de caracteres (char[])
Array.Sort(array) <- Ordena el array alfabéticamente
Array.Reverse(array) <- Invierte los elementos del array
Array.Resize(ref array, 2) <- Recibe como referencia (hay que poner ref) el array y modifica la cantidad de elementos del mismo (borrando elementos o agregando nulls al final)
Array.Clear(array, 0, 2) <- Elimina la cantidad de valores según el segundo número brindado (2 en el ejemplo) de los elementos desde la posición del primer numero (0 en el ejemplo)

Métodos String
string.Split(",") <- Corta la cadena string en elementos de un array separandolos por el parámetro que se pase al método
String.Join(",", words) <- Une los elementos de un array (words) separados por el primer parámetro que se pasa al método
new String(array) <- Une todos los elementos del array en un string
*/
