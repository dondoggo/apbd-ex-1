using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] liczby = { 1, 2, 3, 4, 5 };

        double suma = 0;
        foreach (var liczba in liczby)
        {
            suma += liczba;
        }
        double srednia = suma / liczby.Length;

        Console.WriteLine($"Średnia z tablicy wynosi: {srednia}");
    }
}
