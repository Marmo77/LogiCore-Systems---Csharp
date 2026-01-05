// See https://aka.ms/new-console-template for more information
using System;

// MAGAZYN
class Magazyn
{
    // Podstawowe dane
    int id;
    string localization;
    string name;
    
    // Limit Miejsca
    float prodDailyLimit;
    float actualProd = 0;

    // ograniczenia
    //X

    //lista produtkow
    Dictionary<Produkt, int> produkty = new Dictionary<Produkt,int>();

    public Magazyn(string name,  string localization, int prodLimit)
    {
        Random randID = new Random();
        this.id = randID.Next();
        this.localization = localization;
        this.name = name;
        this.prodDailyLimit = prodLimit;
        this.produkty = new Dictionary<Produkt,int>();

    }

    public void DaneFirmy()
    {
        Console.WriteLine($"----- DANE FIRMY {name.ToUpper()} -----");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Lokalizacaja: {localization}");
        Console.WriteLine($"Maksymalna pojemność : {prodDailyLimit}");
        Console.WriteLine($"Aktualnie zajęte: {actualProd}");
        Console.WriteLine($"---------------------------------------");
    }

    public bool DodajProduktDoMagazynu(Produkt produkt, int ilosc)
    {
        // zajmowana przestrzen produktem (maslo nie zajmuje tyle miejsca co pralka) 
        // podstawowe rownanie -> (SpaceTakenItem - [waga produktu * rozmiar / 100] * ilosc)
        float spaceTaken = produkt.SpaceTakenItem * ilosc;
        // sprawdzamy czy dodanie nie przekroczy limitu
        if (actualProd + spaceTaken > prodDailyLimit)
        {
            Console.WriteLine("Limit dziennych przesyłek w magazynie");
            return false;
        }

        actualProd += spaceTaken;

        // sprawdza czy produkt juz istnieje w Dict, jesli tak to dodaje do niego ilosc, inaczej dodajemy nowy produkt do listy.
        if (produkty.ContainsKey(produkt))
            produkty[produkt] += ilosc;
        else
            produkty.Add(produkt, ilosc);

        Console.WriteLine($"{produkt.Name} został pomyślnie dodany do magazynu w ilości {ilosc} \n");
        return true;
    }
    public void IleZostaloMiejsca()
    {
        // w % pokazuje ile zostalo miejsca w magazynie
        float spaceLeft = (actualProd / prodDailyLimit) * 100;
        Console.WriteLine("---- MIEJSCE W MAGAZYNIE ----");
        Console.WriteLine($"Aktualne zajęto: {spaceLeft}% magazynu");
        Console.WriteLine("-----------------------------");
    }

    public void PokazMagazyn()
    {
        Console.WriteLine("------- ZASOBY MAGAZYNU -------");
        if (produkty.Count == 0)
        {
            Console.WriteLine("Brak produktów w magazynie.");
            return;
        }

        // Iterujemy po parach: klucz = Produkt, wartość = ilość
        foreach (var kvp in produkty)
        {
            var produkt = kvp.Key;
            var ilosc = kvp.Value;

            // Możesz użyć metody produktu do wyświetlenia szczegółów
            produkt.PokazProdukt();
            Console.WriteLine($"Ilość w magazynie: {ilosc}");
            Console.WriteLine($"Zajmowane miejsce w magazynie: {produkt.SpaceTakenItem * ilosc}");
            Console.WriteLine("-----------------------------");
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
    public float SpaceTakenItem;


    public Produkt(int id, string name, float weight, int size, ProduktTyp type)
    {
        this.id = id;
        Name = name;
        Weight = weight;
        Size = size;
        Type = type;
        SpaceTakenItem = (weight * size) / 100; // zajmowane miejsce procentowo w magazynie
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

        // Firma ma własny magazyn i kilka rzeczy p1,..,p4
        Magazyn MlekoTomka = new Magazyn("Mleko Wujka Tomka Export", "Berlin", 100);
        MlekoTomka.DaneFirmy();

        // przykładowe produkty
        Produkt p1 = new Produkt(1, "Mleko", 1f, 1, ProduktTyp.Standard);
        Produkt p2 = new Produkt(2, "Masło", 0.1f, 1, ProduktTyp.Standard);
        Produkt p3 = new Produkt(1, "Maszyna Do Mieszania Mleka", 220f, 5, ProduktTyp.Gabarytowy);
        Produkt p4 = new Produkt(1, "Ser", 0.5f, 1, ProduktTyp.Standard);

        // DODAWANIE PRODUKTOW DO LISTY I DODAWANIE DO MAGAZYNU FIRMY
        var produktyTomka = new Dictionary<Produkt, int>
        {
            { p1, 2000 },
            { p2, 300 },
            { p3, 3 },
            { p4, 200 }
        };

        foreach (var kvp in produktyTomka)
        {
            MlekoTomka.DodajProduktDoMagazynu(kvp.Key, kvp.Value);
        }

        MlekoTomka.PokazMagazyn();
        MlekoTomka.IleZostaloMiejsca();



    }
}