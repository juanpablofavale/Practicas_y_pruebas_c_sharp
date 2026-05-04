Console.WriteLine("Modificación de cadenas con métodos de tipo de datos integrados.");
Console.WriteLine("");
/*

//Contenido entre paréntesis

string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


//Contenido entre etiquetas

string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


//Contenido entre etiquetas sin valores mágicos
//para evitar que al cambiar algo en el texto no se falle en la cantidad inicial

string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openPosition = message.IndexOf(openSpan);
int closePosition = message.IndexOf(closeSpan);

openPosition += openSpan.Length;
int length = closePosition - openPosition;
Console.WriteLine(message.Substring(openPosition, length));

string message = "hello there!";

int first_h = message.IndexOf('h');
int last_h = message.LastIndexOf('h');

Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");


//El último contenido de la cadena

string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');
openingPosition += 1;

int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


//Todos los contenidos de la cadena

string message = "(What if) I am (only interested) in the last (set of parentheses)?";

do
{
	int openingPosition = message.IndexOf('(');
	if (openingPosition == -1) break;
	
	openingPosition += 1;
	int closingPosition = message.IndexOf(')');
	int length = closingPosition - openingPosition;
	Console.WriteLine(message.Substring(openingPosition, length));
	
	message = message.Substring(closingPosition + 1);
}while (message.Length >= 0);


//Buscando diferentes contenidos posibles (array de contenidos)

string message = "Hello, world!";
char[] charsToFind = { 'a', 'e', 'i' };

int index = message.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");


//Se puede buscar desde una posicion inicial

string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");


//Buscar contenido entre estructuras específicas, como por ejemplo ()
//se mejoraron algunos aspectos para que tenga en cuenta que no exista el cierre

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

//while (true) esto se propone en el curso de microsoft
while (closingPosition < message.Length)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);
	if (closingPosition == -1)
	{
		Console.WriteLine($"No se encuentra el símbolo de cierre '{matchingSymbol}'");
		closingPosition = openingPosition + 1;
		continue;
	}

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}


//Eliminar y reemplazar datos en una cadena

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
*/


//

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

const string startSpan = "<span>";
const string endSpan = "</span>";
int startSpanPosition = input.IndexOf(startSpan) + startSpan.Length;
int endSpanPosition = input.IndexOf(endSpan);
int length = endSpanPosition - startSpanPosition;
quantity = input.Substring(startSpanPosition, length);
quantity = $"Quantity: {quantity}";

const string tradeSymbol = "&trade";
const string regSymbol = "&reg";
output = input.Replace(tradeSymbol, regSymbol);

const string openDiv = "<div>";
int openDivPos = output.IndexOf(openDiv);
output.Remove(openDivPos, openDiv.Length);

const string closeDiv = "</div>";
int closeDivPos = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(closeDivPos, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);
