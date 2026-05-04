Console.WriteLine("Expresiones Booleanas\n");

/*
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine("1" == "2");

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
*/

/*
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");
*/

/*
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);
*/

/*
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
*/

/*
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False
*/

/*
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
*/

/*
int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
*/

/* ejercicio 1
Random rnd = new Random();
int numero = rnd.Next(2);
Console.WriteLine((numero == 1 ? "Cara" : "Cruz"));
*/

/* ejercicio 2

*/

string permission = "Admin|Manager";
int level = 55;
string respuesta;
if (permission.Contains("Admin"))
{
 respuesta = level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.";
}
else if (permission.Contains("Director"))
{
 respuesta = level > 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.";
}
else
{
 respuesta = "You do not have sufficient privileges.";
}
Console.WriteLine(respuesta);