//para cambiar punto por coma se pueden utiliozar estas dos instrucciones
using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

Console.WriteLine("Conversion de datos\n");

/*
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);
Console.WriteLine("");
*/

/* conversion de ampliacion
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
*/

/* conversion de restriccion
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

//conversion por coercion (int)myDecimal
int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
*/

/*
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");
*/

/*
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);
*/

/*
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);
*/

/*
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");
*/

/*
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string cadena = "";
decimal total = 0m;

foreach (string value in values)
{
    decimal numero;
    if (decimal.TryParse(value, out numero))
    { 
        total += numero; 
    }
    else
    {
        cadena += value;
    }
    Console.WriteLine($"{numero}");
}

Console.WriteLine($"Message: {cadena}");
Console.WriteLine($"Total: {total}");
*/

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32((value1 / value2));
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = (decimal)(value2 / (decimal)value3);
Console.WriteLine($"Divide value2 by value3, display the result as an decimal: {result2}");

float result3 = (float)(value3 / value1);
Console.WriteLine($"Divide value3 by value1, display the result as an float: {result3}");
