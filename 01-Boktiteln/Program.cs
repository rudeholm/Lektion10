/* 1. Boktiteln (Deklarera en klass & fält)
Skapa en klass `Bok` med de publika fälten `Titel` och `Forfattare` (båda string). Skapa en instans av
klassen i `Main`, tilldela värden och skriv ut dem i konsolen. */

namespace _01_Boktiteln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bok bok = new Bok();
            bok.Titel = "Liftarens Guide till Galaxen";
            bok.Författare = "Douglas Adams";

            Console.WriteLine($"Bok: {bok.Titel}, Författare: {bok.Författare}");
        }
    }
}

public class Bok
{
    public string Titel;
    public string Författare;
}