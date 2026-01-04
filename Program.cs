// See https://aka.ms/new-console-template for more information
using System;

class Magazyn
{
    public Magazyn()
    {
        Console.WriteLine("Witamy w Magazynie!");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("HELLO!");

        Magazyn mag1 = new Magazyn();
    }
}