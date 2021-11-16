// See https://aka.ms/new-console-template for more information
using Abstract_Klasse_og_interface;

Leopard l = new Leopard();
Console.Write("skriv et navn til din Leopard: ");

try
{
    l.Navn = Console.ReadLine();
}
catch (IOException e)
{
    Console.WriteLine(e);
}

Console.WriteLine($"{l.Navn} spiser {l.Eating()}");