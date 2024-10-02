using System.Runtime.ExceptionServices;
using System.Xml.XPath;

Console.Write("Enter number between 0-255: ");
try
{
    byte first = byte.Parse(Console.ReadLine()!);
    Console.Write("Enter another number between 0-255: ");
    byte second = byte.Parse(Console.ReadLine()!);
    int res = first / second;

    Console.WriteLine($"{first} divided by {second} is {res}");
}
catch (Exception e)
{
    Console.WriteLine($"{e.GetType()}: {e.Message}");
}

