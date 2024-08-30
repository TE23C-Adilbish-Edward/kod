string name;

Console.WriteLine("Skriv in ditt namn");
name = Console.ReadLine();

string mat;

Console.WriteLine("Skriv in din favoriträtt");
mat = Console.ReadLine();

string verb;

Console.WriteLine("Skriv in ett nummer");
verb = Console.ReadLine();

Console.Clear();
Console.WriteLine(name + " åt " + mat + " till middag och senare gick " + name + " och vann " + verb + "kr på casinot");
Console.ReadLine()