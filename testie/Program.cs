using System.Collections.Generic;

var katten = new List<Kat>
{
    new Kat("Minoes", 3),
    new Kat("Snorremans", 5),
    new Kat("Poesje", 1)
};

Console.WriteLine("Overzicht van katten:");
for (int i = 0; i < katten.Count; i++)
{
    var huidigeKat = katten[i];
    Console.WriteLine($"{i + 1}. Naam: {huidigeKat.Naam}, Leeftijd: {huidigeKat.Leeftijd}");
}

Console.WriteLine();
Console.WriteLine("Alle katten laten miauwen:");
foreach (var cat in katten)
{
    cat.Miauw();
}

var mijnKat = new Kat("Minoes", 3);
Console.WriteLine($"Naam: {mijnKat.Naam}, Leeftijd: {mijnKat.Leeftijd}");
mijnKat.Miauw();
mijnKat.Eet();

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

    public void Eet()
    {
        Console.WriteLine($"{Naam} eet lekker.");
    }
}
