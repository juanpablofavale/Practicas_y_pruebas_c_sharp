using System;
using System.Linq;
using System.Xml.Linq;

Console.WriteLine("Leer archivo XML con LINQ\n");

string xmlRutaArchivo = @"E:\Documentos\Programacion\C#\pruebacsharp\XML\Ejemplo.xml";

void MostrarElemento(string nombreElemento, string rutaArchivo)
{	

	XElement element = new XElement("Root", XElement.Load(rutaArchivo));

	//Filtrar y buscar un elemento (etiqueta <>) en el arbol XML completo
	//var elementos = from e in element.Descendants().Elements(nombreElemento) select e;
	var elementos = from e in element.Descendants() 
		//Filtrar por nombre de elemento
		where e.Name == nombreElemento 
		//Filtrar por valor (Value) de elemento
		//Esto da para hacer una busqueda general, por lo que si no se busca por nombre completo
		//Trae cada etiqueta padre que tenga un hijo que tenga lo buscado
		//<Root> <Pepe> <Catalog> <Book> <Author> <- un registro por cada etiqueta padre del autor que tenga el nombre
		//where ((string)e) == "Garcia, Debra"
		select e;

	foreach (var elemento in elementos)
	{
		Console.WriteLine(elemento);
	}
}

MostrarElemento("Catalog", xmlRutaArchivo);
