// See https://aka.ms/new-console-template for more information

var kat = new Kat("Minoes", 3);
Console.WriteLine($"Naam: {kat.Naam}, Leeftijd: {kat.Leeftijd}");
kat.Miauw();
kat.Eet();

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
        Console.WriteLine("Miauw!");
    }

    public void Eet()
    {
        Console.WriteLine($"{Naam} eet lekker.");
    }
}
