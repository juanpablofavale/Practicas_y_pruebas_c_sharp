using System.Xml;

Console.WriteLine("Leer y mostrar datos de archivo XML con XmlTextReader\n");
string pathArchivoXML = "E:\\Documentos\\Programacion\\C#\\pruebacsharp\\XML\\SWH.config";
//string pathArchivoXML = "E:\\Documentos\\Programacion\\C#\\pruebacsharp\\XML\\Ejemplo.xml";

XmlTextReader reader = new XmlTextReader(pathArchivoXML);

int cascada = 0;
bool esVacio = false;
int cantidadEspacios = 4;

while( reader.Read() )
{
	/*	
	if (reader.Name!=null)
	{
		Console.WriteLine($"Type: {reader.NodeType}");
		Console.WriteLine($"Name: {reader.Name}");
		Console.WriteLine($"Content: {reader.Value}");
	}
	*/
	
	//Console.WriteLine($"Type: {reader.NodeType}");
	esVacio = reader.IsEmptyElement;
	//Console.WriteLine($"{reader.Name} es de tipo {reader.NodeType} vacio? {reader.IsEmptyElement} - Cascada: {cascada}");
	
	switch (reader.NodeType)
    {
        case XmlNodeType.Element: // The node is an element.
			//Cantidad de atributos
			//Console.WriteLine($"Cantidad de atributos: {reader.AttributeCount}");

			Console.Write($"{new string(' ', cascada * cantidadEspacios)}<{reader.Name}");
		
			while (reader.MoveToNextAttribute())
			{
				Console.Write(" " + reader.Name + "='" + reader.Value + "'");
			}
			
			Console.WriteLine(">");
		
			if ( !esVacio )
			{
				cascada++;
			}
            break;

        case XmlNodeType.Text: //Display the text in each element.
            Console.WriteLine($"{new string(' ', cascada * cantidadEspacios)}{reader.Value}");
            break;

        case XmlNodeType.EndElement: //Display the end of the element.
			cascada--;
			Console.WriteLine($"{new string(' ', cascada * cantidadEspacios)}</{reader.Name}>");
            break;
    }
}
