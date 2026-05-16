using System;
using System.IO;
using System.Xml;

Console.WriteLine("Leer y mostrar archivo XML con XmlDocument\n");

string xmlRutaArchivo = "E:\\Documentos\\Programacion\\C#\\pruebacsharp\\XML\\Ejemplo.xml";

XmlDocument doc = new XmlDocument();

XmlReader reader = XmlReader.Create(xmlRutaArchivo);
doc.Load(reader);
Console.WriteLine(doc.OuterXml + "\n");



XmlDocument doc2 = new();
string xmlData = "<book xmlns:bk='urn:samples'></book>";

doc2.Load(new StringReader(xmlData));

// Create a new element and add it to the document.
XmlElement 
elem = doc2.CreateElement("bk", "genre", "urn:samples");
elem.InnerText = "fantasy";
doc2.DocumentElement.AppendChild(elem);
elem = doc2.CreateElement("bk", "genre", "urn:samples");
elem.InnerText = "fantasy2";
doc2.DocumentElement.AppendChild(elem);

Console.WriteLine("Display the modified XML...");
doc2.Save(Console.Out);
