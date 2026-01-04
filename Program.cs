// See https://aka.ms/new-console-template for more information
using System;

// MAGAZYN
class Magazyn
{
    // Podstawowe dane
    int id;
    string localization;
    string name;
    
    // Wysyłki
    int prodDailyLimit;
    int actualProd;
    
    // ograniczenia
    //X

    public Magazyn(string name,  string localization, int prodLimit)
    {
        Random randID = new Random();
        this.id = randID.Next();
        this.localization = localization;
        this.name = name;
        this.prodDailyLimit = prodLimit;

    }

    public void DaneFirmy()
    {
        Console.WriteLine($"----- DANE FIRMY {name.ToUpper()} -----");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Lokalizacaja: {localization}");
        Console.WriteLine($"Limit Dzienny Wysyłek: {prodDailyLimit}");
        Console.WriteLine($"Aktualna Liczba Wysyłek: {actualProd}");
    }

    public bool CzyMozeWyslac()
    {
        if (actualProd > prodDailyLimit)
        {
            return true;
        }
        else
        { 
           return false; 
        }
    }
}

// PRODUKT
enum ProduktTyp
{
    Standard,
    Kruchy,
    Niebezpieczny,
    Gabarytowy
}

class Produkt
{
    public int id;
    public string Name { get; set; }
    public float Weight { get; set; }
    public int Size { get; set; }
    public ProduktTyp Type { get; set; }

    public Produkt(int id, string name, float weight, int size, ProduktTyp type)
    {
        this.id = id;
        Name = name;
        Weight = weight;
        Size = size;
        Type = type;
    }

    public void PokazProdukt()
    {
        Console.WriteLine($"Produkt {id}: {Name}, Typ: {Type}, Waga: {Weight}, Rozmiar: {Size}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("HELLO!");

        Magazyn mag1 = new Magazyn("Kasztan Export", "Berlin", 24);
        mag1.DaneFirmy();

        // Przykład tworzenia produktu z dozwolonym typem
        Produkt p1 = new Produkt(1, "Szklanka", 0.5f, 1, ProduktTyp.Kruchy);
        p1.PokazProdukt();

    }
}