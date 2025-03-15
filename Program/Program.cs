using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Witaj w programie!");
        Console.Write("Jak masz na imię? ");
        string imie = Console.ReadLine();

        Console.WriteLine($"Witaj, {imie}!");

        Console.Write("Ile masz lat? ");
        int wiek = int.Parse(Console.ReadLine()); 
        int lataDo100 = 100 - wiek;
        Console.WriteLine($"Za {lataDo100} lat będziesz miał(a) 100 lat.");
    }
}
