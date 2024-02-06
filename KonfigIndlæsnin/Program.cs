// See https://aka.ms/new-console-template for more information
using System.Xml;

Console.WriteLine("Hello, World!");


XmlDocument xml = new XmlDocument();
xml.Load("ConfigFile.xml");

Console.WriteLine("Name");
XmlNode? nameNode = xml.DocumentElement.SelectSingleNode("Name");
if (nameNode is not null)
{
    string nameStr = nameNode.InnerText.Trim();
    Console.WriteLine( "Name: " + nameStr );
}

Console.WriteLine("Number");
XmlNode? numberNode = xml.DocumentElement.SelectSingleNode("Number");
if (numberNode is not null)
{
    string numberStr = numberNode.InnerText.Trim();
    int number = int.Parse(numberStr);

    Console.WriteLine("Number: " + number);
}