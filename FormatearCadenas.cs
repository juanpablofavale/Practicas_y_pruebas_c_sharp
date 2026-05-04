Console.WriteLine("Aplicar formato a datos alfanuméricos para su presentación");
Console.WriteLine("");

/*
//	Aplicación de formato a cadenas alfanuméricas

string first = "Hello";
string second = "World";
Console.WriteLine(string.Format("{1} {0}!", first, second));
Console.WriteLine(string.Format("{0} {0} {0}!", first, second));
Console.WriteLine("");
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
Console.WriteLine("");

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
Console.WriteLine("");


//	Aplicación de formato a números

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");
Console.WriteLine("");


decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
Console.WriteLine("");

decimal price1 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price1 - salePrice), price1);

yourDiscount += $"A discount of {((price1 - salePrice) / price1):P2}!";
Console.WriteLine(yourDiscount);
Console.WriteLine("");

decimal tax1 = .12051m;
Console.WriteLine($"Tax rate: {tax1:P1}");
*/

/*
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: \t{invoiceNumber}");
Console.WriteLine($"\tShares: \t{productShares:N3} Product");
Console.WriteLine($"\tSubtotal: \t{subtotal:C}");
Console.WriteLine($"\tTax: \t\t{taxPercentage:P2}");
Console.WriteLine($"\tTotal: \t\t{total:C}");
*/

/*
string input = "Pad this";
Console.WriteLine("-" + input.PadLeft(12) + "-");
Console.WriteLine("-" + input.PadRight(12) + "-");
Console.WriteLine("-" + input.PadLeft(12, '\\') + "-"); //<- espera un char con comillas simples (comillas doble es string) O.o
Console.WriteLine("-" + input.PadRight(12, '/') + "-");
*/

/*
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5.000,00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);
*/

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n");
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";
//string currentProfitStr = $"{currentProfit:C}"; //ORIGINAL
//comparisonMessage += $"{currentProduct.PadRight(20)}{currentReturn:P}{currentProfitStr.PadLeft(17)}\n";
comparisonMessage += currentProduct.PadRight(20);
comparisonMessage += $"{currentReturn:P}".PadRight(10);
comparisonMessage += $"{currentProfit:C}".PadRight(20) + "\n";
//string newProfitStr = $"{newProfit:C}"; //ORIGINAL
//comparisonMessage += $"{newProduct.PadRight(20)}{newReturn:P2}{newProfitStr.PadLeft(17)}";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += $"{newReturn:P2}".PadRight(10);
comparisonMessage += $"{newProfit:C}".PadRight(20);

// Your logic here

Console.WriteLine(comparisonMessage);
