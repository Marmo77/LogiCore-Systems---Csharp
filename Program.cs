// See https://aka.ms/new-console-template for more information
using System;
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
}



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("HELLO!");

        Magazyn mag1 = new Magazyn("Kasztan Export", "Berlin", 24);
        mag1.DaneFirmy();
    }
}