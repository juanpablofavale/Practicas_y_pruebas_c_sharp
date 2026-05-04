Console.WriteLine("Probando Bloques de código y los ámbitos que se pueden generar");

bool flag = true;
int value = 0;

if (flag)
{
  Console.WriteLine($"Dentro del bloque de código: {value}");
}

value = 10;
Console.WriteLine($"Fueda del bloque de código: {value}");

bool flag1 = true;
if (flag1) Console.WriteLine(flag1);

string name = "steve";

if (name == "bob") 
  Console.WriteLine("Found Bob");
else if (name == "steve") 
  Console.WriteLine("Found Steve");
else 
  Console.WriteLine("Found Chuck");

int[] numbers = { 4, 8, 15, 16, 23, 42};
int total = 0;
bool found = false;

foreach (int number in numbers)
{
  total += number;

  if (number == 42)
    found = true;
}

if (found)
  Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
