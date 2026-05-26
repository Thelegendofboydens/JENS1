// See https://aka.ms/new-console-template for more information

var katten = new List<Kat>
{
    new Kat("Minoes", 3),
    new Kat("Snorremans", 5),
    new Kat("Poesje", 1)
};

Console.WriteLine("Overzicht van katten:");
for (int i = 0; i < katten.Count; i++)
{
    var kat = katten[i];
    Console.WriteLine($"{i + 1}. Naam: {kat.Naam}, Leeftijd: {kat.Leeftijd}");
}

Console.WriteLine();
Console.WriteLine("Alle katten laten miauwen:");
foreach (var kat in katten)
{
    kat.Miauw();
}

public class Kat
{
    public string Naam { get; set; }
    public int Leeftijd { get; set; }

    public Kat(string naam, int leeftijd)
    {
        Naam = naam;
        Leeftijd = leeftijd;
    }

    public void Miauw()
    {
        Console.WriteLine($"{Naam} zegt: Miauw!");
    }
}
